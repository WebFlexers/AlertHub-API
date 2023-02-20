using AlertHub.Api.Models.FCM;
using AlertHub.Api.Services;
using AlertHub.Data;
using AlertHub.Data.DTOs;
using AlertHub.Data.Entities;
using AlertHub.Data.Entities.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace AlertHub.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DangerNotificationController : ControllerBase
{
    private readonly ILogger<DangerNotificationController> _logger;
    private readonly ApplicationDbContext _dbContext;
    private readonly INotificationService _notificationService;

    public DangerNotificationController(ILogger<DangerNotificationController> logger, ApplicationDbContext dbContext, 
        INotificationService notificationService)
    {
        _logger = logger;
        _dbContext = dbContext;
        _notificationService = notificationService;
    }

    [Authorize(Roles = "Civil_Protection")]
    [HttpPost("CreateAndSendNotification")]
    public async Task<IActionResult> CreateAndSendNotification([FromBody] CreateNotificationDTO notificationDTO)
    {
        try
        {
            var timeSent = DateTime.UtcNow;
            var givenLocation = CreatePointFromCoordinates(notificationDTO.Latitude, notificationDTO.Longitude);

            var nearbyUserLocations = await _dbContext.UserLocations
                .AsNoTracking()
                .Where(ul => ul.Location.IsWithinDistance(givenLocation, notificationDTO.RadiusInMeters))
                .ToListAsync();

            var isAtLeastOneNotificationSent = false;
            var utcNow = DateTime.UtcNow;

            foreach (var userLocation in nearbyUserLocations)
            {
                var userFcm = await _dbContext.UserFcmDeviceIds
                    .AsNoTracking()
                    .FirstOrDefaultAsync(fcm => fcm.UserId.Equals(userLocation.UserId));

                if (userFcm == null)
                {
                    continue;
                }

                await _notificationService.SendNotificationAsync(new NotificationModel
                {
                    Title = $"There is a {notificationDTO.DisasterType.ToLower()} in {notificationDTO.Municipality}! Run.",
                    Body = $"{notificationDTO.Directions}\nSent at {utcNow.ToString("F")}",
                    DeviceId = userFcm.DeviceId,
                    IsAndroidDevice = true
                });

                isAtLeastOneNotificationSent = true;
            }

            if (isAtLeastOneNotificationSent == false)
            {
                return BadRequest("No registered users found in the specified area");
            }

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

    [HttpPost("SaveDeviceId")]
    public async Task<IActionResult> SaveDeviceId(string userId, string deviceId, CancellationToken cancellationToken)
    {
        try
        {
            var existingUserWithId = await _dbContext.UserFcmDeviceIds
                .FirstOrDefaultAsync(fcm => fcm.UserId.Equals(userId), cancellationToken);

            if (existingUserWithId == null)
            {
                await _dbContext.UserFcmDeviceIds.AddAsync(new UserFcmDeviceId
                {
                    DeviceId = deviceId,
                    UserId = userId
                }, cancellationToken);
            }
            else
            {
                existingUserWithId.DeviceId = deviceId;
            }

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while trying to save device id: {deviceId} for user: {userId}",
                deviceId, userId);
            return BadRequest();
        }
    }

    private Point CreatePointFromCoordinates(double latitude, double longitude)
    {
        var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
        return geometryFactory.CreatePoint(new Coordinate(longitude, latitude))!;
    }
}
