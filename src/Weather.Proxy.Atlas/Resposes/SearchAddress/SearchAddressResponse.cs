using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class SearchAddressResponse
{
    [JsonPropertyName("summary")] public SummaryResponse Summary { get; set; }

    [JsonPropertyName("results")] public AddressResultResponse[] Results { get; set; }
}