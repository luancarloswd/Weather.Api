using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class PoiResponse
{
    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("categorySet")] public CategorySetResponse[] CategorySet { get; set; }

    [JsonPropertyName("categories")] public string[] Categories { get; set; }

    [JsonPropertyName("classifications")] public ClassificationResponse[] Classifications { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("brands")]
    public BrandResponse[] Brands { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}