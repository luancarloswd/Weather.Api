using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class GeometryResponse
{
    [JsonPropertyName("id")] public Guid Id { get; set; }
}