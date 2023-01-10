using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class SummaryResponse
{
    [JsonPropertyName("query")] public string Query { get; set; }

    [JsonPropertyName("queryType")] public string QueryType { get; set; }

    [JsonPropertyName("queryTime")] public long QueryTime { get; set; }

    [JsonPropertyName("numResults")] public long NumResults { get; set; }

    [JsonPropertyName("offset")] public long Offset { get; set; }

    [JsonPropertyName("totalResults")] public long TotalResults { get; set; }

    [JsonPropertyName("fuzzyLevel")] public long FuzzyLevel { get; set; }

    [JsonPropertyName("queryIntent")] public object[] QueryIntent { get; set; }
}