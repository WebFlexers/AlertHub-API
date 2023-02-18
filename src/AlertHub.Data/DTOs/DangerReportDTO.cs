using AlertHub.Data.Entities.Enums;
using NetTopologySuite.Geometries;

namespace AlertHub.Data.DTOs;

public class DangerReportDTO
{
    public int Id { get; set; }
    public string DisasterType { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public DateTime CreatedAt { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public string Country { get; set; }
    public string Municipality { get; set; }
    public string Culture { get; set; }

    public string UserId { get; set; }
}
