using AlertHub.Data.Entities.Enums;
using NetTopologySuite.Geometries;

namespace AlertHub.Data.Entities;

public class DangerNotification
{
    public int Id { get; set; }
    public Point Location { get; set; }
    public DateTime CreatedAt { get; set; }
    public DisasterType DisasterType { get; set; }
    public string Country { get; set; }
    public string Municipality { get; set; }
    public string Directions { get; set; }
}
