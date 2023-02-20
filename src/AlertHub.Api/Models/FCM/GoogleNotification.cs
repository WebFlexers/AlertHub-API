using Newtonsoft.Json;

namespace AlertHub.Api.Models.FCM;

public class GoogleNotification
{
    [JsonProperty("priority")]
    public string Priority { get; set; } = "high";
    [JsonProperty("data")]
    public DataPayload Data { get; set; }
    [JsonProperty("notification")]
    public DataPayload Notification { get; set; }
}