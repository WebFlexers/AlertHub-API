namespace AlertHub.Data.Entities;

public class ArchivedDangerReport
{
    public int Id { get; set; }

    public int DangerReportId { get; set; }
    public DangerReport DangerReport { get; set; }
}
