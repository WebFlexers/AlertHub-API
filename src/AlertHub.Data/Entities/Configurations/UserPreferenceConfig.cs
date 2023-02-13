using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlertHub.Data.Entities.Configurations;

public class UserPreferenceConfig : IEntityTypeConfiguration<UserPreference>
{
    public void Configure(EntityTypeBuilder<UserPreference> builder)
    {
        builder.HasKey(up => up.Id);

        builder.Property(up => up.Culture)
            .IsRequired(true)
            .HasMaxLength(400);

        builder.Property(up => up.UserId)
            .IsRequired(true);
    }
}
