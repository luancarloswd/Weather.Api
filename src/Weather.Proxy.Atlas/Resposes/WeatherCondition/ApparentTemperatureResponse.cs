using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes;

public class ApparentTemperatureResponse
{
    [JsonPropertyName("value")] public double Value { get; set; }

    [JsonPropertyName("unit")] public string Unit { get; set; }

    [JsonPropertyName("unitType")] public long UnitType { get; set; }
}