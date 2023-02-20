using AlertHub.Data;
using AlertHub.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace AlertHub.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserLocationController : ControllerBase
{
    private readonly ILogger<UserLocationController> _logger;
    private readonly ApplicationDbContext _dbContext;

    public UserLocationController(ILogger<UserLocationController> logger, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpPost("CreateOrUpdateUserLocation")]
    public async Task<IActionResult> CreateOrUpdateUserLocation(double latitude, double longitude, string userId)
    {
        try
        {
            var existingUserLocation = await _dbContext.UserLocations
                .FirstOrDefaultAsync(ul => ul.UserId.Equals(userId));

            if (existingUserLocation is null)
            {
                await _dbContext.AddAsync(new UserLocation
                {
                    Location = CreatePointFromCoordinates(latitude, longitude),
                    UserId = userId
                });

                await _dbContext.SaveChangesAsync();
            
                _logger.LogInformation("Successfully stored location for user with id {id}", userId);

                return Ok("Created user location");
            }
            else
            {
                existingUserLocation.Location = CreatePointFromCoordinates(latitude, longitude);

                await _dbContext.SaveChangesAsync();

                _logger.LogInformation("Successfully updated location for user with id {id}", userId);

                return Ok("Updated user location");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,"Something went wrong when trying to store user location for user with id: {id}", userId);
            return BadRequest();
        }
    }

    private Point CreatePointFromCoordinates(double latitude, double longitude)
    {
        var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
        return geometryFactory.CreatePoint(new Coordinate(longitude, latitude))!;
    }
}
