using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlertHub.Data.Entities.Configurations;

public class DangerReportConfig : IEntityTypeConfiguration<DangerReport>
{
    public void Configure(EntityTypeBuilder<DangerReport> builder)
    {
        builder.HasKey(dr => dr.Id);

        builder.Property(dr => dr.DisasterType)
            .IsRequired(true);

        builder.Property(dr => dr.Location)
            .IsRequired(true);

        builder.Property(dr => dr.CreatedAt)
            .IsRequired(true);
        builder.HasIndex(dr => dr.CreatedAt);

        builder.Property(dr => dr.DisasterType)
            .IsRequired(true);

        builder.Property(dr => dr.ImageName)
            .IsRequired(false)
            .HasMaxLength(200);

        builder.Property(dr => dr.Description)
            .IsRequired(false)
            .HasMaxLength(2000);

        builder.Property(dr => dr.Status)
            .IsRequired(true);

        builder.Property(dr => dr.Culture)
            .IsRequired(true)
            .HasMaxLength(10);

        builder.Property(dr => dr.UserId)
            .IsRequired(true);
    }
}
