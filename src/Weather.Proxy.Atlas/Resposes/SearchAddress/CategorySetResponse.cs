using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class CategorySetResponse
{
    [JsonPropertyName("id")] public long Id { get; set; }
}