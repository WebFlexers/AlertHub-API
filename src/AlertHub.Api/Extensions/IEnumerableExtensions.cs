using AlertHub.Data.Entities;

namespace AlertHub.Api.Extensions;

public static class IEnumerableExtensions
{
    public static string? GetCountryByCulture(this IEnumerable<CoordinatesInformation> source, string culture, 
        int dangerReportId, List<CoordinatesInformation> coordinatesInfo)
    {
        return source.Any(ci => ci.DangerReportId.Equals(dangerReportId)) ?
            coordinatesInfo
                .First(ci => ci.DangerReportId.Equals(dangerReportId) &&
                    ci.Culture.Equals(culture))!.Country : null;
    }

    public static string? GetMunicipalityByCulture(this IEnumerable<CoordinatesInformation> source, string culture,
        int dangerReportId, List<CoordinatesInformation> coordinatesInfo)
    {
        return source.Any(ci => ci.DangerReportId.Equals(dangerReportId)) ?
            coordinatesInfo
                .First(ci => ci.DangerReportId.Equals(dangerReportId) &&
                    ci.Culture.Equals(culture))!.Municipality : null;
    }




    //public static string? GetMunicipalityByCulture(this IEnumerable<CoordinatesInformation> source, string culture, ActiveDangerReport activeReport)
    //{
    //    return source.Any(ci => ci.DangerReportId.Equals(activeReport.DangerReportId)) ?
    //        activeReport.DangerReport.CoordinatesInformation
    //            .First(ci => ci.DangerReportId.Equals(activeReport.DangerReportId) &&
    //                         ci.Culture.Equals(culture))!.Municipality : null;
    //}
}
