using AlertHub.Data.Entities;
using AlertHub.Data.Entities.Enums;
using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace AlertHub.Data.Seeding;

public class SampleData
{
    private readonly ModelBuilder _modelBuilder;

    private const int SeedNumber = 869236954;
    private const int UsersNumber = 100;
    
    private readonly Random _random = new(SeedNumber);

    private readonly List<(string, string)> _countriesMunicipalities = new()
    {
        new("Greece", "Agia Varvara"),
        new("Greece", "Agios Dimitrios"),
        new("Greece", "Aigaleo"),
        new("Greece", "Alimos"),
        new("Greece", "Alonnisos"),
        new("Greece", "Ampelokipoi"),
        new("Greece", "Ilioupoli"),
        new("Greece", "Irakleio"),
        new("Greece", "Kalamata"),
        new("Greece", "Kallithea"),
    };
    private readonly List<string> _cultures = new()
    {
        "en-US",
        "el-GR"
    };
    // Used to get the passwords from debug, since they are encrypted in the database
    private readonly Dictionary<string, string> _usernamesPasswords = new();

    private List<IdentityRole> _roles = new();
    private readonly List<IdentityUser> _users = new();
    private readonly List<IdentityUserRole<string>> _usersRoles = new();
    private readonly List<DangerReport> _dangerReports = new();
    private readonly List<ActiveDangerReport> _activeDangerReports = new();
    private readonly List<ArchivedDangerReport> _archivedDangerReports = new();

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
        //CreateDangerReports();

        _modelBuilder.Entity<IdentityRole>().HasData(_roles);
        //_modelBuilder.Entity<IdentityUser>().HasData(_users);
        //_modelBuilder.Entity<IdentityUserRole<string>>().HasData(_usersRoles);
        //_modelBuilder.Entity<DangerReport>().HasData(_dangerReports);
        //_modelBuilder.Entity<ActiveDangerReport>().HasData(_activeDangerReports);
        //_modelBuilder.Entity<ArchivedDangerReport>().HasData(_archivedDangerReports);
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

                var passwordHasher = new PasswordHasher<IdentityUser>();
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

    private void CreateDangerReports()
    {
        int dangerReportId = 1;
        int archivedReportId = 1;
        int activeReportId = 1;

        var dangerReportsFaker = new Faker<DangerReport>()
            .CustomInstantiator(f =>
            {
                var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
                var location = geometryFactory.CreatePoint(
                    new Coordinate(GetRandomDouble(21, 24), GetRandomDouble(37, 39)))!;
                var countryMunicipality = f.PickRandom(_countriesMunicipalities);

                ReportStatus status;
                var randomNum = _random.Next(1, 100);
                if (randomNum > 80)
                {
                    var randomNum2 = _random.Next(1, 3);
                    status = randomNum2 > 1 ? ReportStatus.Rejected : ReportStatus.Approved;
                }
                else
                {
                    status = ReportStatus.Pending;
                }

                var report = new DangerReport
                {
                    Id = dangerReportId++,
                    DisasterType = f.Random.Enum<DisasterType>(),
                    Location = location,
                    ImageName = null,
                    Description = f.Lorem.Paragraphs(_random.Next(1, 4)),
                    Status = status,
                    // TODO: Add Country and Municipality to the correct table
                    Culture = f.PickRandom(_cultures),
                    UserId = f.PickRandom(_users).Id
                };

                
                if (status == ReportStatus.Approved || status == ReportStatus.Rejected)
                {
                    _archivedDangerReports.Add(new ArchivedDangerReport { Id = archivedReportId++, DangerReportId = report.Id });
                }
                else
                {
                    _activeDangerReports.Add(new ActiveDangerReport { Id = activeReportId++, DangerReportId = report.Id });
                }

                return report;
            });

        _dangerReports.AddRange(dangerReportsFaker.Generate(UsersNumber * 3));
    }

    private Guid GenerateSeededGuid(int seed)
    {
        var guid = new byte[16];
        _random.NextBytes(guid);

        return new Guid(guid);
    }

    public double GetRandomDouble(double minimum, double maximum)
    {
        return _random.NextDouble() * (maximum - minimum) + minimum;
    }
}