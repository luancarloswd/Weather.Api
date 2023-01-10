using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes;

public class WeatherConditionResultsResponse
{
    [JsonPropertyName("results")] public WeatherConditionResponse[] Results { get; set; }
}