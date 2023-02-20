using Microsoft.AspNetCore.Identity;

namespace AlertHub.Data.Entities;

public class UserFcmDeviceId
{
    public int Id { get; set; }
    public string DeviceId { get; set; }

    public string UserId { get; set; }
    public IdentityUser User { get; set; }
}
