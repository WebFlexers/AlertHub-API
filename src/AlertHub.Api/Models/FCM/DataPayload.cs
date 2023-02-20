using Newtonsoft.Json;

namespace AlertHub.Api.Models.FCM;

public class DataPayload
{
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("body")]
    public string Body { get; set; }
}
