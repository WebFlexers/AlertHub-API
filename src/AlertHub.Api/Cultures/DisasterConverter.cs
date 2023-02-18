using AlertHub.Data.Entities.Enums;

namespace AlertHub.Api.Cultures;

public static class DisasterConverter
{
    public static readonly Dictionary<DisasterType, string> DisasterTypesEnglish = new()
    {
        { DisasterType.Flood, "Flood" },
        { DisasterType.Wildfire, "Wildfire" },
        { DisasterType.Earthquake, "Earthquake" },
        { DisasterType.Cyclone, "Cyclone" },
        { DisasterType.Hailstorm, "Hailstorm" },
        { DisasterType.Tornado, "Tornado" },
        { DisasterType.Other, "Other" },
    };

    public static readonly Dictionary<DisasterType, string> DisasterTypesGreek = new()
    {
        { DisasterType.Flood, "Πλημμύρα" },
        { DisasterType.Wildfire, "Πυρκαγιά" },
        { DisasterType.Earthquake, "Σεισμός" },
        { DisasterType.Cyclone, "Κυκλώνας" },
        { DisasterType.Hailstorm, "Χαλαζόπτωση" },
        { DisasterType.Tornado, "Σίφωνας" },
        { DisasterType.Other, "Άλλο" },
    };

    public static string TranslateDisaster(DisasterType disasterType, string culture)
    {
        switch (culture)
        {
            case "en-US":
                return DisasterTypesEnglish[disasterType];
            case "el-GR":
                return DisasterTypesGreek[disasterType];
        }

        return string.Empty;
    }
}
