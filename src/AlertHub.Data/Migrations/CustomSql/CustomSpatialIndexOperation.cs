using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace AlertHub.Data.Migrations.CustomSql;

public class CreateSpatialIndexOperation : MigrationOperation
{
    public string Table { get; set; }
    public string Column { get; set; }
}
