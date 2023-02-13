using NetTopologySuite.Geometries;

namespace AlertHub.Data.Entities;

public class DangerNotification
{
    public int Id { get; set; }
    public Point Location { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Culture { get; set; }
    public string Directions { get; set; }
}
