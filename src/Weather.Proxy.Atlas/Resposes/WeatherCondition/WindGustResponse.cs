using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes;

public class WindGustResponse
{
    [JsonPropertyName("speed")] public ApparentTemperatureResponse Speed { get; set; }
}