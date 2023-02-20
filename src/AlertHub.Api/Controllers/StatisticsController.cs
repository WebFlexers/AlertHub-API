using AlertHub.Api.Cultures;
using AlertHub.Data;
using AlertHub.Data.Entities.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlertHub.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StatisticsController : ControllerBase
{
    private readonly ILogger<StatisticsController> _logger;
    private readonly ApplicationDbContext _dbContext;

    public StatisticsController(ILogger<StatisticsController> logger, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet("GetActiveDisastersNumbers")]
    public async Task<ActionResult> GetActiveDisastersNumbers(string culture)
    {
        try
        {
            var disastersNumbers = await _dbContext.ActiveDangerReports
                .AsNoTracking()
                .GroupBy(adr => new { DisasterType = adr.DangerReport.DisasterType })
                .Select(group => new
                {
                    DisasterType = culture.ToLower() == "en-us" ?
                        group.Key.DisasterType.ToString() :
                        DisasterConverter.TranslateDisaster(group.Key.DisasterType, culture),
                    ActiveReportsNumber = group.Count()
                })
                .ToListAsync();

            return Ok(disastersNumbers);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while trying to get active disasters number statistic");
            return BadRequest();
        }
    }
}
