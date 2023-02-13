using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlertHub.Data.Entities.Configurations;

public class UserLocationConfig : IEntityTypeConfiguration<UserLocation>
{
    public void Configure(EntityTypeBuilder<UserLocation> builder)
    {
        builder.HasKey(ul => ul.Id);

        builder.Property(ul => ul.UserId)
            .IsRequired(true);

        builder.Property(ul => ul.Location)
            .IsRequired(true);
    }
}
