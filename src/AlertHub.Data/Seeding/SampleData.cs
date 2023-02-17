using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AlertHub.Data.Seeding;

public class SampleData
{
    private readonly ModelBuilder _modelBuilder;

    private const int SeedNumber = 869236954;
    private const int UsersNumber = 100;
    
    private readonly Random _random = new(SeedNumber);
    private readonly Dictionary<string, string> _usernamesPasswords = new();

    private List<IdentityRole> _roles = new();
    private List<IdentityUser> _users = new();
    private List<IdentityUserRole<string>> _usersRoles = new();

    public SampleData(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        Randomizer.Seed = _random;

        //if (System.Diagnostics.Debugger.IsAttached == false)
        //{
        //    System.Diagnostics.Debugger.Launch();
        //}

        CreateRoles();
        //CreateUsers();
        //CreateUsersRoles();

        _modelBuilder.Entity<IdentityRole>().HasData(_roles);
        //_modelBuilder.Entity<IdentityUser>().HasData(_users);
        //_modelBuilder.Entity<IdentityUserRole<string>>().HasData(_usersRoles);
    }

    private void CreateRoles()
    {
        var guid1 = GenerateSeededGuid(SeedNumber).ToString();
        var guid2 = GenerateSeededGuid(SeedNumber).ToString();

        _roles = new List<IdentityRole>
        {
            new IdentityRole { Id = guid1, Name = "Simple_User", NormalizedName = "SIMPLE_USER", ConcurrencyStamp = guid1 },
            new IdentityRole { Id = guid2, Name = "Civil_Protection", NormalizedName = "CIVIL_PROTECTION", ConcurrencyStamp = guid2 }
        };
    }

    private void CreateUsers()
    {
        var userFaker = new Faker<IdentityUser>()
            .CustomInstantiator(f =>
            {
                var email = f.Person.Email;
                var username = f.Person.UserName;

                var user = new IdentityUser
                {
                    Id = GenerateSeededGuid(SeedNumber).ToString(),
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    EmailConfirmed = false,
                    UserName = username,
                    NormalizedUserName = username.ToUpper(),
                    ConcurrencyStamp = GenerateSeededGuid(SeedNumber).ToString(),
                    LockoutEnabled = true,
                };

                var password = f.Internet.Password();

                var passwordHasher = new ConsistentPasswordHasher<IdentityUser>(SeedNumber);
                user.PasswordHash = passwordHasher.HashPassword(user, password);

                _usernamesPasswords.Add(user.UserName, password);

                return user;
            });

        _users.AddRange(userFaker.Generate(UsersNumber));
    }

    private void CreateUsersRoles()
    {
        for (int i = 0; i < _users.Count; i++)
        {
            _usersRoles.Add(new IdentityUserRole<string>
            {
                RoleId = i < 5 ? _roles[1].Id : _roles[0].Id,
                UserId = _users[i].Id
            });   
        }
    }

    private Guid GenerateSeededGuid(int seed)
    {
        var guid = new byte[16];
        _random.NextBytes(guid);

        return new Guid(guid);
    }
}