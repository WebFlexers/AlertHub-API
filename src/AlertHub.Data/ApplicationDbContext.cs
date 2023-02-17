using System;
using System.Reflection;
using AlertHub.Data.Entities;
using AlertHub.Data.Seeding;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlertHub.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    private readonly UserManager<IdentityUser> _userManager;

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        new SampleData(modelBuilder).Seed();
    }

    public DbSet<DangerNotification> DangerNotifications { get; set; }
    public DbSet<ActiveDangerReport> ActiveDangerReports { get; set; }
    public DbSet<ArchivedDangerReport> ArchivedDangerReports { get; set; }
    public DbSet<DangerReport> DangerReports { get; set; }
    public DbSet<UserLocation> UserLocations { get; set; }
}
