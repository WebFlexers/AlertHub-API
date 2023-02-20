using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlertHub.Data.Entities.Configurations;

public class DangerNotificationConfig : IEntityTypeConfiguration<DangerNotification>
{
    public void Configure(EntityTypeBuilder<DangerNotification> builder)
    {
        builder.HasKey(dn => dn.Id);

        builder.Property(dn => dn.Location)
            .IsRequired(true);

        builder.Property(dn => dn.CreatedAt)
            .IsRequired(true);

        builder.Property(dn => dn.DisasterType)
            .IsRequired(true);

        builder.Property(dn => dn.Country)
            .IsRequired(true)
            .HasMaxLength(450);

        builder.Property(dn => dn.Municipality)
            .IsRequired(true)
            .HasMaxLength(450);

        builder.Property(dn => dn.Directions)
            .IsRequired(true)
            .HasColumnType("nvarchar(max)");
    }
}
