using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes;

public class PastHoursResponse
{
    [JsonPropertyName("minimum")] public ApparentTemperatureResponse Minimum { get; set; }

    [JsonPropertyName("maximum")] public ApparentTemperatureResponse Maximum { get; set; }
}