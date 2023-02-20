using AlertHub.Data;
using AlertHub.Data.DTOs;
using AlertHub.Data.Entities;
using AlertHub.Data.Entities.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace AlertHub.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DangerNotificationController : ControllerBase
{
    private readonly ILogger<DangerNotificationController> _logger;
    private readonly ApplicationDbContext _dbContext;

    public DangerNotificationController(ILogger<DangerNotificationController> logger, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAndSendNotification([FromBody] CreateNotificationDTO notificationDTO)
    {
        try
        {
            var timeSent = DateTime.UtcNow;
            // TODO: Send the notification to mobile phone using FCM

            var dangerNotification = new DangerNotification
            {
                Location = CreatePointFromCoordinates(notificationDTO.Latitude, notificationDTO.Longitude),
                CreatedAt = timeSent,
                DisasterType = Enum.Parse<DisasterType>(notificationDTO.DisasterType),
                Country = notificationDTO.Country,
                Municipality = notificationDTO.Municipality,
                Directions = notificationDTO.Directions
            };

            await _dbContext.DangerNotifications.AddAsync(dangerNotification);

            await _dbContext.SaveChangesAsync();

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while trying to create and send a notification");
            return BadRequest();
        }
    }

    private Point CreatePointFromCoordinates(double latitude, double longitude)
    {
        var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
        return geometryFactory.CreatePoint(new Coordinate(longitude, latitude))!;
    }
}
