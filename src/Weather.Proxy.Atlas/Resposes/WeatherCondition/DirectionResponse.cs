using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes;

public class DirectionResponse
{
    [JsonPropertyName("degrees")] public double Degrees { get; set; }

    [JsonPropertyName("localizedDescription")]
    public string LocalizedDescription { get; set; }
}