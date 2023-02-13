using System;
using System.Reflection;
using AlertHub.Data.Entities;
using AlertHub.Data.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlertHub.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<IdentityRole>().HasData(new List<IdentityRole>
        {
            new IdentityRole { Name = "Simple_User", NormalizedName = "SIMPLE_USER"},
            new IdentityRole { Name = "Civil_Protection", NormalizedName = "CIVIL_PROTECTION"}
        });

        new SampleData().Seed(modelBuilder);
    }

    public DbSet<DangerNotification> DangerNotifications { get; set; }
    public DbSet<DangerReport> DangerReports { get; set; }
    public DbSet<UserLocation> UserLocations { get; set; }
    public DbSet<UserPreference> UserPreferences { get; set; }
}
