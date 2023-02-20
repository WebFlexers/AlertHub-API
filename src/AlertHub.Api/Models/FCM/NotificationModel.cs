using Newtonsoft.Json;

namespace AlertHub.Api.Models.FCM;

public class NotificationModel
{
    [JsonProperty("deviceId")]
    public string DeviceId { get; set; }
    [JsonProperty("IsAndroidDevice")]
    public bool IsAndroidDevice { get; set; }
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("body")]
    public string Body { get; set; }
}