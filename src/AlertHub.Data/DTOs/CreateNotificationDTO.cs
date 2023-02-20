namespace AlertHub.Data.DTOs;

public class CreateNotificationDTO
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double RadiusInMeters { get; set; }
    public string DisasterType { get; set; }
    public string Country { get; set; }
    public string Municipality { get; set; }
    public string Directions { get; set; }
}
