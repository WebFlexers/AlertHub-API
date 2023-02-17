using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlertHub.Data.Entities.Configurations;

public class ActiveDangerReportConfig : IEntityTypeConfiguration<ActiveDangerReport>
{
    public void Configure(EntityTypeBuilder<ActiveDangerReport> builder)
    {
        builder.HasKey(adr => adr.Id);

        builder.Property(adr => adr.DangerReportId)
            .IsRequired(true);
    }
}
