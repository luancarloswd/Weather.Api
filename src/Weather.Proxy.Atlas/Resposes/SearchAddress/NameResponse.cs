using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class NameResponse
{
    [JsonPropertyName("nameLocale")] public string NameLocale { get; set; }

    [JsonPropertyName("name")] public string NameName { get; set; }
}