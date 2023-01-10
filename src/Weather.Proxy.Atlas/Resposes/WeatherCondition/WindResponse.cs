using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes;

public class WindResponse
{
    [JsonPropertyName("direction")] public DirectionResponse Direction { get; set; }

    [JsonPropertyName("speed")] public ApparentTemperatureResponse Speed { get; set; }
}