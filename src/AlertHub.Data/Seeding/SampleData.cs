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

    private readonly List<(string, string)> _countriesMunicipalitiesEnglish = new()
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
    private readonly List<(string, string)> _countriesMunicipalitiesGreek = new()
    {
        new("Ελλάδα", "Αγία Βαρβάρα"),
        new("Ελλάδα", "Άγιος Δημήτριος"),
        new("Ελλάδα", "Αιγάλεω"),
        new("Ελλάδα", "Άλιμος"),
        new("Ελλάδα", "Αλόννησος"),
        new("Ελλάδα", "Αμπελόκηποι"),
        new("Ελλάδα", "Ηλιούπολη"),
        new("Ελλάδα", "Ηράκλειο"),
        new("Ελλάδα", "Καλαμάτα"),
        new("Ελλάδα", "Καλλιθέα"),
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
    private readonly List<CoordinatesInformation> _coordinatesInformation = new();
    private readonly List<UserLocation> _userLocations = new();

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
        CreateUsers();
        CreateUsersRoles();
        CreateDangerReports();
        CreateUserLocations();

        _modelBuilder.Entity<IdentityRole>().HasData(_roles);
        _modelBuilder.Entity<IdentityUser>().HasData(_users);
        _modelBuilder.Entity<IdentityUserRole<string>>().HasData(_usersRoles);
        _modelBuilder.Entity<DangerReport>().HasData(_dangerReports);
        _modelBuilder.Entity<ActiveDangerReport>().HasData(_activeDangerReports);
        _modelBuilder.Entity<ArchivedDangerReport>().HasData(_archivedDangerReports);
        _modelBuilder.Entity<CoordinatesInformation>().HasData(_coordinatesInformation);
        _modelBuilder.Entity<UserLocation>().HasData(_userLocations);
    }

    private void CreateRoles()
    {
        var guid1 = GenerateSeededGuid().ToString();
        var guid2 = GenerateSeededGuid().ToString();

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
                    Id = GenerateSeededGuid().ToString(),
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    EmailConfirmed = false,
                    UserName = username,
                    NormalizedUserName = username.ToUpper(),
                    ConcurrencyStamp = GenerateSeededGuid().ToString(),
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
        int coordinatesInfoId = 1;

        var dangerReportsFaker = new Faker<DangerReport>()
            .CustomInstantiator(f =>
            {
                var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
                var location = geometryFactory.CreatePoint(
                    new Coordinate(GetRandomDouble(21, 24), GetRandomDouble(37, 39)))!;

                DateTime datetime;
                ReportStatus status;

                var randomNum = _random.Next(1, 100);
                if (randomNum > 80)
                {
                    var randomNum2 = _random.Next(1, 3);
                    status = randomNum2 > 1 ? ReportStatus.Rejected : ReportStatus.Approved;
                    datetime = f.Date.Past(1, new DateTime(2023, 2, 18)).ToUniversalTime();
                }
                else
                {
                    status = ReportStatus.Pending;
                    datetime = f.Date.Recent(1, new DateTime(2023, 2, 18)).ToUniversalTime();
                }

                var report = new DangerReport
                {
                    Id = dangerReportId++,
                    DisasterType = f.Random.Enum<DisasterType>(),
                    CreatedAt = datetime,
                    Location = location,
                    ImageName = null,
                    Description = f.Lorem.Paragraphs(_random.Next(1, 3)),
                    Status = status,
                    Culture = f.PickRandom(_cultures),
                    UserId = f.PickRandom(_users).Id
                };

                var randomCountryMuniIndex = _random.Next(0, _countriesMunicipalitiesEnglish.Count);

                var countryMunicipalityEnglish = _countriesMunicipalitiesEnglish[randomCountryMuniIndex];
                _coordinatesInformation.Add(new CoordinatesInformation
                {
                    Id = coordinatesInfoId++,
                    Culture = "en-US",
                    Country = countryMunicipalityEnglish.Item1,
                    Municipality = countryMunicipalityEnglish.Item2,
                    DangerReportId = report.Id,
                });

                var countryMunicipalityGreek = _countriesMunicipalitiesGreek[randomCountryMuniIndex];
                _coordinatesInformation.Add(new CoordinatesInformation
                {
                    Id = coordinatesInfoId++,
                    Culture = "el-GR",
                    Country = countryMunicipalityGreek.Item1,
                    Municipality = countryMunicipalityGreek.Item2,
                    DangerReportId = report.Id,
                });

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

    private void CreateUserLocations()
    {
        int userLocationId = 1;

        foreach (var user in _users)
        {
            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
            var location = geometryFactory.CreatePoint(
                new Coordinate(GetRandomDouble(21, 24), GetRandomDouble(37, 39)))!;

            _userLocations.Add(new UserLocation
            {
                Id = userLocationId++,
                Location = location,
                UserId = user.Id,
            });
        }
    }

    private Guid GenerateSeededGuid()
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