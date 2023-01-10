using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class PositionResponse
{
    [JsonPropertyName("lat")] public double Lat { get; set; }

    [JsonPropertyName("lon")] public double Lon { get; set; }
}