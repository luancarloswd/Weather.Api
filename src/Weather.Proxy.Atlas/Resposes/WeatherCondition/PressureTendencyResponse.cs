using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes;

public class PressureTendencyResponse
{
    [JsonPropertyName("localizedDescription")]
    public string LocalizedDescription { get; set; }

    [JsonPropertyName("code")] public string Code { get; set; }
}