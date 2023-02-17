using Microsoft.AspNetCore.Identity;

namespace AlertHub.Data.Seeding;

public class ConsistentPasswordHasher<TUser> : PasswordHasher<TUser> where TUser : class
{
    private readonly int _seed;

    public ConsistentPasswordHasher(int seed)
    {
        _seed = seed;
    }

    public override string HashPassword(TUser user, string password)
    {
        string input = _seed + password; // add the seed to the input
        return base.HashPassword(user, input); // call the base method to produce the hash
    }
}