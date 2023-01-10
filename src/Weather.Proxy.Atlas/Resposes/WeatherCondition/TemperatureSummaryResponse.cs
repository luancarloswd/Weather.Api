using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes;

public class TemperatureSummaryResponse
{
    [JsonPropertyName("past6Hours")] public PastHoursResponse Past6Hours { get; set; }

    [JsonPropertyName("past12Hours")] public PastHoursResponse Past12Hours { get; set; }

    [JsonPropertyName("past24Hours")] public PastHoursResponse Past24Hours { get; set; }
}