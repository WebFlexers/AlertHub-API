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
using AlertHub.Api.Cultures;
using Hangfire;

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

            string imageName;
            Task uploadTask;

            if (dangerReportDTO.ImageFile is not null)
            {
                var imageExtension = dangerReportDTO.ImageFile.ContentType.Split("/")[1];
                imageName = $"{Guid.NewGuid().ToString()}.{imageExtension}";
                uploadTask = Task.Run(async () =>
                {
                    await UploadImage(imageName, dangerReportDTO.ImageFile, cancellationToken);
                }, cancellationToken);
            }
            else
            {
                imageName = "no-image.png";
                uploadTask = Task.CompletedTask;
            }

            var newDangerReport = await CreateDangerReportFromDTO(dangerReportDTO, imageName);

            // Begin a transaction and only commit it only if no exceptions
            // are thrown. Otherwise roll the changes back
            await _dbContext.Database.BeginTransactionAsync(cancellationToken);

            await _dbContext.DangerReports.AddAsync(newDangerReport, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            await _dbContext.ActiveDangerReports.AddAsync(new ActiveDangerReport
            {
                DangerReportId = newDangerReport.Id,
            }, cancellationToken);

            // Fire and run (and hodl)
            BackgroundJob.Enqueue(() =>
                CreateCoordinatesInformation(newDangerReport.Location.X, newDangerReport.Location.Y, 
                                                      newDangerReport.Id, cancellationToken)
            );

            await _dbContext.SaveChangesAsync(cancellationToken);

            await uploadTask;

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

    [HttpGet("GetActiveReportsByTimeDescending")]
    public async Task<ActionResult<List<DangerReportDTO>>> Get(int pageNumber, int itemsPerPage, string culture)
    {
        try
        {
            string rootPath = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
            var imagesPath = $@"{rootPath}/UploadDangerReportImages";

            var reports = await _dbContext.ActiveDangerReports
                .AsNoTracking()
                .OrderByDescending(activeReport => activeReport.DangerReport.CreatedAt)
                .Paginate(pageNumber, itemsPerPage)
                .Select(activeReport => new DangerReportDTO
                {
                    Id = activeReport.DangerReportId,
                    DisasterType = activeReport.DangerReport.DisasterType.ToString(),
                    Longitude = activeReport.DangerReport.Location.X,
                    Latitude = activeReport.DangerReport.Location.Y,
                    CreatedAt = activeReport.DangerReport.CreatedAt,
                    ImageUrl = activeReport.DangerReport.ImageName != null ? 
                        $@"{imagesPath}/{activeReport.DangerReport.ImageName}" : 
                        null,
                    Description = activeReport.DangerReport.Description,
                    Status = activeReport.DangerReport.Status.ToString(),
                    Culture = activeReport.DangerReport.Culture,
                    Country = activeReport.DangerReport.CoordinatesInformation
                        .GetCountryByCulture(culture, activeReport.DangerReportId, activeReport.DangerReport.CoordinatesInformation),
                    Municipality = activeReport.DangerReport.CoordinatesInformation
                        .GetMunicipalityByCulture(culture, activeReport.DangerReportId, activeReport.DangerReport.CoordinatesInformation),
                    UserId = activeReport.DangerReport.UserId,
                })
                .ToListAsync();

            if (culture.Equals("en-US")) return Ok(reports);

            foreach (var report in reports)
            {
                report.DisasterType = DisasterConverter.TranslateDisaster(
                    Enum.Parse<DisasterType>(report.DisasterType), culture);

                report.Status = StatusConverter.TranslateStatus(
                    Enum.Parse<ReportStatus>(report.Status), culture);
            }

            return Ok(reports);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception occurred while fetching paginated " +
                                 "danger reports sorted by time descending");
            return BadRequest();
        }
    }

    [HttpGet("GetReportsByImportance")]
    public async Task<ActionResult> GetReportsByImportance(int pageNumber, int itemsPerPage, string culture)
    {
        var reports = await _dbContext.CoordinatesInformation
            .AsNoTracking()
            .Where(ci => ci.DangerReport.ActiveDangerReport.DangerReportId.Equals(ci.DangerReportId))
            .Where(ci => ci.Culture.Equals(culture))
            .GroupBy(ci => new { ci.Municipality })
            .Select(group => new { Municipality = group.Key.Municipality ,Importance = group.Count(), DangerReports = group.ToList() })
            .OrderByDescending(group => group.Importance)
            .Paginate(pageNumber, itemsPerPage)
            .ToListAsync();

        return Ok(reports);
    }

    private async Task UploadImage(string imageName, IFormFile imageFile, CancellationToken cancellationToken)
    {
        var imagesPath = Path.Combine(_environment.WebRootPath, "UploadDangerReportImages");
        if (Directory.Exists(imagesPath) == false) {
            Directory.CreateDirectory(imagesPath);
        }

        await using FileStream fileStream = System.IO.File.Create(Path.Combine(imagesPath, imageName));
        await imageFile.CopyToAsync(fileStream, cancellationToken);
        await fileStream.FlushAsync(CancellationToken.None);
        _logger.LogInformation("Successfully uploaded image {imageName}", imageName);
    }

    private Task<DangerReport> CreateDangerReportFromDTO(CreateDangerReportDTO reportDTO, string imageName)
    {
        var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

        var disasterType = Enum.Parse<DisasterType>(reportDTO.DisasterType);
        var longitude = double.Parse(reportDTO.Longitude);
        var latitude = double.Parse(reportDTO.Latitude);
        var location = geometryFactory.CreatePoint(new Coordinate(longitude, latitude))!;
        var nowUtc = DateTime.UtcNow;

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

        return Task.FromResult(newDangerReport);
    }

    [NonAction]
    public async Task CreateCoordinatesInformation(double longitude, double latitude, int dangerReportId, CancellationToken cancellationToken)
    {
        var chromeUserAgent = 
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36";
        var firefoxUserAgent =
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:110.0) Gecko/20100101 Firefox/110.0";

        var greekResponse = await FetchCoordinatesInfo(longitude, latitude, "el-GR", chromeUserAgent, cancellationToken);
        await AddCoordinatesInformationToDb(greekResponse, dangerReportId, cancellationToken);
        var englishResponse = await FetchCoordinatesInfo(longitude, latitude, "en-US", firefoxUserAgent, cancellationToken);
        await AddCoordinatesInformationToDb(englishResponse, dangerReportId, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    private async Task AddCoordinatesInformationToDb(NominatimResponse nominatimResponse, int dangerReportId, CancellationToken cancellationToken)
    {
        await _dbContext.CoordinatesInformation.AddAsync(new CoordinatesInformation
        {
            Country = nominatimResponse.Country,
            Municipality = nominatimResponse.Municipality,
            Culture = nominatimResponse.Culture,
            DangerReportId = dangerReportId
        }, cancellationToken);
    }

    private async Task<NominatimResponse> FetchCoordinatesInfo(double longitude, double latitude, string culture, 
        string userAgent, CancellationToken cancellationToken)
    {
        // Get only en from en-US, el from el-GR, etc
        var language = culture.Split("-")[0];

        var nominatimUrl = _config.GetValue<string>("NominatimUrl")!
            .Replace("{longitude}", longitude.ToString(CultureInfo.GetCultureInfo("en-US")))
            .Replace("{latitude}", latitude.ToString(CultureInfo.GetCultureInfo("en-US")))
            .Replace("{language}", language);

        _logger.LogDebug("The url is: {url}", nominatimUrl);

        var httpClient = _httpClientFactory.CreateClient();

        httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);

        var response = await httpClient.GetAsync(nominatimUrl, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"HTTP Error: {response.StatusCode}");
        }

        // Get the country and municipality from the fetch result
        await using var responseStream = await response.Content.ReadAsStreamAsync(cancellationToken);
        using var jsonDocument = await JsonDocument.ParseAsync(responseStream, cancellationToken: cancellationToken);
        var country = jsonDocument.RootElement.GetProperty("address").GetProperty("country").GetString();
        var municipality = jsonDocument.RootElement.GetProperty("address").GetProperty("municipality").GetString();

        return new NominatimResponse { Country = country, Municipality = municipality, Culture = culture };
    }
}
