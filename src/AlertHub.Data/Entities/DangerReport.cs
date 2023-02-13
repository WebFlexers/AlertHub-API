using AlertHub.Data.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using NetTopologySuite.Geometries;

namespace AlertHub.Data.Entities;

public class DangerReport
{
    public int Id { get; set; }
    public DisasterType DisasterType { get; set; }
    public Point Location { get; set; }
    public DateTime CreatedAt { get; set; }
    public string PhotoName { get; set; }
    public string Description { get; set; }
    public ReportStatus Status { get; set; }
    public string Culture { get; set; }

    public string UserId { get; set; }
    public IdentityUser User { get; set; }
}
