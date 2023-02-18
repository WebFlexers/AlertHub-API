using AlertHub.Data.Entities.Enums;

namespace AlertHub.Api.Cultures;

public class StatusConverter
{
    public static readonly Dictionary<ReportStatus, string> DisasterTypesEnglish = new()
    {
        { ReportStatus.Pending, "Pending" },
        { ReportStatus.Approved, "Approved" },
        { ReportStatus.Rejected, "Rejected" },
    };

    public static readonly Dictionary<ReportStatus, string> DisasterTypesGreek = new()
    {
        { ReportStatus.Pending, "Εκκρεμεί" },
        { ReportStatus.Approved, "Εγκεκριμένο" },
        { ReportStatus.Rejected, "Ακυρωμένο" },
    };


    public static string TranslateStatus(ReportStatus reportStatus, string culture)
    {
        switch (culture)
        {
            case "en-US":
                return DisasterTypesEnglish[reportStatus];
            case "el-GR":
                return DisasterTypesGreek[reportStatus];
        }

        return string.Empty;
    }
}
