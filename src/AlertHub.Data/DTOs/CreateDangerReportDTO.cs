using AlertHub.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace AlertHub.Data.DTOs;

public class CreateDangerReportDTO
{
    public string DisasterType { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public IFormFile ImageFile { get; set; }
    public string Description { get; set; }
    public string Culture { get; set; }
    public string UserId { get; set; }
}
