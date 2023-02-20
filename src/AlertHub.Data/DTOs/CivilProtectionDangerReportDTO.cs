namespace AlertHub.Data.DTOs;

public class CivilProtectionDangerReportDTO
{
    public int Id { get; set; }
    public string DisasterType { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public DateTime CreatedAt { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
