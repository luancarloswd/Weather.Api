using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class BrandResponse
{
    [JsonPropertyName("name")] public string Name { get; set; }
}