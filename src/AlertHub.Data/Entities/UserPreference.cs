using Microsoft.AspNetCore.Identity;

namespace AlertHub.Data.Entities;

public class UserPreference
{
    public int Id { get; set; }
    public string Culture { get; set; }

    public string UserId { get; set; }
    public IdentityUser User { get; set; }
}
