using AlertHub.Data;
using AlertHub.Data.DTOs;
using AlertHub.Data.Entities;
using AlertHub.Data.Entities.Enums;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite;
using NetTopologySuite.Geometries;

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

    [Authorize]
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

            var disasterType = Enum.Parse<DisasterType>(dangerReport.DisasterType);

            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
            var longitude = double.Parse(dangerReport.Longitude);
            var latitude = double.Parse(dangerReport.Latitude);
            var location = geometryFactory.CreatePoint(new Coordinate(longitude, latitude))!;
            var nowUtc = DateTime.UtcNow;
            string imageName = null;

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

                await using(FileStream fileStream = System.IO.File.Create(Path.Combine(imagesPath, imageName))) {
                    await dangerReport.ImageFile.CopyToAsync(fileStream);
                    await fileStream.FlushAsync();
                }
            }

            await _dbContext.Database.CommitTransactionAsync(cancellationToken);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception was thrown while trying to create a danger report");
            await _dbContext.Database.RollbackTransactionAsync();
            return BadRequest();
        }
    }
}
