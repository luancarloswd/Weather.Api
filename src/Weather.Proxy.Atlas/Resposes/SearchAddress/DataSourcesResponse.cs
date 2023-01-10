using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class DataSourcesResponse
{
    [JsonPropertyName("geometry")] public GeometryResponse Geometry { get; set; }
}