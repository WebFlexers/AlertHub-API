using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlertHub.Data.Entities.Configurations;

public class UserFcmDeviceIdConfig : IEntityTypeConfiguration<UserFcmDeviceId>
{
    public void Configure(EntityTypeBuilder<UserFcmDeviceId> builder)
    {
        builder.HasKey(fcm => fcm.Id);

        builder.Property(fcm => fcm.DeviceId)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(fcm => fcm.UserId)
            .IsRequired();
    }
}
