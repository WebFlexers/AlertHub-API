namespace AlertHub.Data.DTOs;

public class ArchivedDangerReportDTO
{
    public int Id { get; set; }
    public string DisasterType { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Country { get; set; }
    public string Municipality { get; set; }
}
