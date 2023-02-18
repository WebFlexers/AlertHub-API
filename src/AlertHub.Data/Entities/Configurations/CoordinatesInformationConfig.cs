using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlertHub.Data.Entities.Configurations;

public class CoordinatesInformationConfig : IEntityTypeConfiguration<CoordinatesInformation>
{
    public void Configure(EntityTypeBuilder<CoordinatesInformation> builder)
    {
        builder.HasKey(ci => ci.Id);

        builder.Property(ci => ci.Country)
            .IsRequired(true)
            .HasMaxLength(450);
        builder.HasIndex(ci => ci.Country);

        builder.Property(ci => ci.Municipality)
            .IsRequired(true)
            .HasMaxLength(450);
        builder.HasIndex(ci => ci.Municipality);
        
        builder.Property(ci => ci.Culture)
            .IsRequired(true)
            .HasMaxLength(10);
        builder.HasIndex(ci => ci.Culture);

        builder.Property(ci => ci.DangerReportId)
            .IsRequired(true);

        builder.HasOne(ci => ci.DangerReport)
            .WithMany(dr => dr.CoordinatesInformation)
            .HasForeignKey(ci => ci.DangerReportId);
    }
}
