using AlertHub.Api.Extensions;
using AlertHub.Data;
using AlertHub.Data.DTOs;
using AlertHub.Data.Entities;
using AlertHub.Data.Entities.Enums;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using System.Composition;
using System.Globalization;
using AlertHub.Api.Models;
using System.Net.Http;
using System.Security.Policy;
using System.Text.Json;

namespace AlertHub.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DangerReportController : ControllerBase
{
    private readonly ILogger<ApplicationDbContext> _logger;
    private readonly ApplicationDbContext _dbContext;
    private readonly IConfiguration _config;
    private readonly IValidator<CreateDangerReportDTO> _reportValidator;
    private readonly IWebHostEnvironment _environment;
    private readonly IHttpClientFactory _httpClientFactory;

    public DangerReportController(ILogger<ApplicationDbContext> logger, ApplicationDbContext dbContext, IConfiguration config,
        IValidator<CreateDangerReportDTO> reportValidator, IWebHostEnvironment environment, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _dbContext = dbContext;
        _config = config;
        _reportValidator = reportValidator;
        _environment = environment;
        _httpClientFactory = httpClientFactory;
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromForm]CreateDangerReportDTO dangerReportDTO, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _reportValidator.ValidateAsync(dangerReportDTO, cancellationToken);

            if (validationResult.IsValid == false)
            {
                var errorsByProperty = new Dictionary<string, string>();
                validationResult.Errors.ForEach(validationFailure =>
                    errorsByProperty.Add(validationFailure.PropertyName, validationFailure.ErrorMessage));
                return BadRequest(new { errors = errorsByProperty });
            }

            var newDangerReport = await CreateDangerReportFromDTO(dangerReportDTO);

            // Begin a transaction and only commit it if the photo
            // uploads successfully. Otherwise roll the changes back
            await _dbContext.Database.BeginTransactionAsync(cancellationToken);

            await _dbContext.DangerReports.AddAsync(newDangerReport, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            await _dbContext.ActiveDangerReports.AddAsync(new ActiveDangerReport
            {
                DangerReportId = newDangerReport.Id,
            }, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);

            if (dangerReportDTO.ImageFile is not null)
            {
                await UploadImage(newDangerReport, dangerReportDTO.ImageFile, cancellationToken);
            }

            await _dbContext.Database.CommitTransactionAsync(cancellationToken);
            _logger.LogInformation("Successfully created danger report by user: {userid}", newDangerReport.UserId);

            return Ok(new {DangerReportId = newDangerReport.Id});
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception was thrown while trying to create a danger report");

            if (_dbContext.Database.CurrentTransaction != null)
            {
                await _dbContext.Database.RollbackTransactionAsync(CancellationToken.None);
            }

            return BadRequest();
        }
    }

    [HttpGet("GetByTimeDescending/{pageNumber}/{itemsPerPage}")]
    public async Task<ActionResult<List<DangerReport>>> Get(int pageNumber, int itemsPerPage)
    {
        try
        {
            string rootPath = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
            var imagesPath = $@"{rootPath}/UploadDangerReportImages";

            var reports = await _dbContext.DangerReports
                .AsNoTracking()
                .OrderByDescending(report => report.CreatedAt)
                .Paginate(pageNumber, itemsPerPage)
                .Select(report => new DangerReportDTO
                {
                    Id = report.Id,
                    DisasterType = report.DisasterType,
                    Longitude = report.Location.X,
                    Latitude = report.Location.Y,
                    CreatedAt = report.CreatedAt,
                    ImageUrl = report.ImageName != null ? 
                        $@"{imagesPath}/{report.ImageName}" : 
                        null,
                    Description = report.Description,
                    Status = report.Status,
                    Culture = report.Culture,
                    UserId = report.UserId,
                })
                .ToListAsync();

            return Ok(reports);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception occurred while fetching paginated " +
                                 "danger reports sorted by time descending");
            return BadRequest();
        }
    }

    private async Task<DangerReport> CreateDangerReportFromDTO(CreateDangerReportDTO reportDTO)
    {
        var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

        var disasterType = Enum.Parse<DisasterType>(reportDTO.DisasterType);
        var longitude = double.Parse(reportDTO.Longitude);
        var latitude = double.Parse(reportDTO.Latitude);
        var location = geometryFactory.CreatePoint(new Coordinate(longitude, latitude))!;
        var nowUtc = DateTime.UtcNow;
        string imageName;

        if (reportDTO.ImageFile is not null)
        {
            var imageExtension = reportDTO.ImageFile.ContentType.Split("/")[1];
            imageName = $"{Guid.NewGuid().ToString()}.{imageExtension}";
        }
        else
        {
            imageName = "no-image.png";
        }

        var newDangerReport = new DangerReport
        {
            DisasterType = disasterType,
            Location = location,
            CreatedAt = nowUtc,
            ImageName = imageName,
            Description = reportDTO.Description,
            Status = ReportStatus.Pending,
            Culture = reportDTO.Culture,
            UserId = reportDTO.UserId
        };

        var locationInfo = 
            await FetchCountryAndMunicipalityFromCoordinates(newDangerReport.Location, newDangerReport.Culture);

        newDangerReport.Country = locationInfo.Country;
        newDangerReport.Municipality = locationInfo.Municipality;

        return newDangerReport;
    }

    private async Task<NominatimResponse> FetchCountryAndMunicipalityFromCoordinates(Point location, string culture)
    {
        // Get only en from en-US, el from el-GR, etc
        var language = culture.Split("-")[0];

        var nominatimUrl = _config.GetValue<string>("NominatimUrl")!
            .Replace("{longitude}", location.X.ToString(CultureInfo.GetCultureInfo(culture)))
            .Replace("{latitude}", location.Y.ToString(CultureInfo.GetCultureInfo(culture)))
            .Replace("{language}", language);

        var httpClient = _httpClientFactory.CreateClient();
        httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/2.0)");

        var response = await httpClient.GetAsync(nominatimUrl);
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"HTTP Error: {response.StatusCode}");
        }

        await using var responseStream = await response.Content.ReadAsStreamAsync();
        using var jsonDocument = await JsonDocument.ParseAsync(responseStream);
        var country = jsonDocument.RootElement.GetProperty("address").GetProperty("country").GetString();
        var municipality = jsonDocument.RootElement.GetProperty("address").GetProperty("municipality").GetString();

        return new NominatimResponse {Country = country, Municipality = municipality};
    }

    private async Task UploadImage(DangerReport dangerReport, IFormFile imageFile, CancellationToken cancellationToken)
    {
        var imagesPath = Path.Combine(_environment.WebRootPath, "UploadDangerReportImages");
        if (Directory.Exists(imagesPath) == false) {
            Directory.CreateDirectory(imagesPath);
        }

        await using FileStream fileStream = System.IO.File.Create(Path.Combine(imagesPath, dangerReport.ImageName));
        await imageFile.CopyToAsync(fileStream, cancellationToken);
        await fileStream.FlushAsync(CancellationToken.None);
        _logger.LogInformation("Successfully uploaded image {imageName}", dangerReport.ImageName);
    }
}
