using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class EntryPointResponse
{
    [JsonPropertyName("type")] public string Type { get; set; }

    [JsonPropertyName("position")] public PositionResponse Position { get; set; }
}