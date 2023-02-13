using Microsoft.AspNetCore.Identity;
using NetTopologySuite.Geometries;

namespace AlertHub.Data.Entities;

public class UserLocation
{
    public int Id { get; set; }
    public Point Location { get; set; }
    
    public string UserId { get; set; }
    public IdentityUser User { get; set; }
}
