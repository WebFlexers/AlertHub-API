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

namespace AlertHub.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DangerReportController : ControllerBase
{
    private readonly ILogger<ApplicationDbContext> _logger;
    private readonly ApplicationDbContext _dbContext;
    private readonly IValidator<CreateDangerReportDTO> _reportValidator;
    private readonly IWebHostEnvironment _environment;

    public DangerReportController(ILogger<ApplicationDbContext> logger, ApplicationDbContext dbContext,
        IValidator<CreateDangerReportDTO> reportValidator, IWebHostEnvironment environment)
    {
        _logger = logger;
        _dbContext = dbContext;
        _reportValidator = reportValidator;
        _environment = environment;
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromForm]CreateDangerReportDTO dangerReport, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _reportValidator.ValidateAsync(dangerReport, cancellationToken);

            if (validationResult.IsValid == false)
            {
                var errorsByProperty = new Dictionary<string, string>();
                validationResult.Errors.ForEach(validationFailure =>
                    errorsByProperty.Add(validationFailure.PropertyName, validationFailure.ErrorMessage));
                return BadRequest(new { errors = errorsByProperty });
            }

            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

            var disasterType = Enum.Parse<DisasterType>(dangerReport.DisasterType);
            var longitude = double.Parse(dangerReport.Longitude);
            var latitude = double.Parse(dangerReport.Latitude);
            var location = geometryFactory.CreatePoint(new Coordinate(longitude, latitude))!;
            var nowUtc = DateTime.UtcNow;
            string? imageName = null;

            if (dangerReport.ImageFile is not null)
            {
                var imageExtension = dangerReport.ImageFile.ContentType.Split("/")[1];
                imageName = $"{Guid.NewGuid().ToString()}.{imageExtension}";
            }

            var newDangerReport = new DangerReport
            {
                DisasterType = disasterType,
                Location = location,
                CreatedAt = nowUtc,
                ImageName = imageName,
                Description = dangerReport.Description,
                Status = ReportStatus.Pending,
                Culture = dangerReport.Culture,
                UserId = dangerReport.UserId
            };

            // Begin a transaction and only commit it if the photo
            // uploads successfully. Otherwise roll the changes back
            await _dbContext.Database.BeginTransactionAsync(cancellationToken);

            await _dbContext.DangerReports.AddAsync(newDangerReport, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            if (dangerReport.ImageFile is not null)
            {
                var imagesPath = Path.Combine(_environment.WebRootPath, "UploadDangerReportImages");
                if (Directory.Exists(imagesPath) == false) {
                    Directory.CreateDirectory(imagesPath);
                }

                await using FileStream fileStream = System.IO.File.Create(Path.Combine(imagesPath, imageName!));
                await dangerReport.ImageFile.CopyToAsync(fileStream, cancellationToken);
                await fileStream.FlushAsync(CancellationToken.None);
                _logger.LogInformation("Successfully uploaded image {imageName}", imageName);
            }

            await _dbContext.Database.CommitTransactionAsync(cancellationToken);
            _logger.LogInformation("Successfully created danger report by user: {userid}", newDangerReport.UserId);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception was thrown while trying to create a danger report");
            await _dbContext.Database.RollbackTransactionAsync(CancellationToken.None);
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
}
