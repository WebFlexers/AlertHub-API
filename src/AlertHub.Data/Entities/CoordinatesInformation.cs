using NetTopologySuite.Geometries;

namespace AlertHub.Data.Entities;

public class CoordinatesInformation
{
    public int Id { get; set; }
    public string Country { get; set; }
    public string Municipality { get; set; }
    public string Culture { get; set; }

    public int DangerReportId { get; set; }
    public DangerReport DangerReport { get; set; }
}
