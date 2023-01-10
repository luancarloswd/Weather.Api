using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class ClassificationResponse
{
    [JsonPropertyName("code")] public string Code { get; set; }

    [JsonPropertyName("names")] public NameResponse[] Names { get; set; }
}