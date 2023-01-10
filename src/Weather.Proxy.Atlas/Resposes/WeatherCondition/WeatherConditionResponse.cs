using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes;

public class WeatherConditionResponse
{
    [JsonPropertyName("dateTime")] public DateTimeOffset DateTime { get; set; }

    [JsonPropertyName("phrase")] public string Phrase { get; set; }

    [JsonPropertyName("iconCode")] public long IconCode { get; set; }

    [JsonPropertyName("hasPrecipitation")] public bool HasPrecipitation { get; set; }

    [JsonPropertyName("isDayTime")] public bool IsDayTime { get; set; }

    [JsonPropertyName("temperature")] public ApparentTemperatureResponse Temperature { get; set; }

    [JsonPropertyName("realFeelTemperature")]
    public ApparentTemperatureResponse RealFeelTemperature { get; set; }

    [JsonPropertyName("realFeelTemperatureShade")]
    public ApparentTemperatureResponse RealFeelTemperatureShade { get; set; }

    [JsonPropertyName("relativeHumidity")] public long RelativeHumidity { get; set; }

    [JsonPropertyName("dewPoint")] public ApparentTemperatureResponse DewPoint { get; set; }

    [JsonPropertyName("wind")] public WindResponse Wind { get; set; }

    [JsonPropertyName("windGust")] public WindGustResponse WindGust { get; set; }

    [JsonPropertyName("uvIndex")] public long UvIndex { get; set; }

    [JsonPropertyName("uvIndexPhrase")] public string UvIndexPhrase { get; set; }

    [JsonPropertyName("visibility")] public ApparentTemperatureResponse Visibility { get; set; }

    [JsonPropertyName("obstructionsToVisibility")]
    public string ObstructionsToVisibility { get; set; }

    [JsonPropertyName("cloudCover")] public long CloudCover { get; set; }

    [JsonPropertyName("ceiling")] public ApparentTemperatureResponse Ceiling { get; set; }

    [JsonPropertyName("pressure")] public ApparentTemperatureResponse Pressure { get; set; }

    [JsonPropertyName("pressureTendency")] public PressureTendencyResponse PressureTendency { get; set; }

    [JsonPropertyName("past24HourTemperatureDeparture")]
    public ApparentTemperatureResponse Past24HourTemperatureDeparture { get; set; }

    [JsonPropertyName("apparentTemperature")]
    public ApparentTemperatureResponse ApparentTemperature { get; set; }

    [JsonPropertyName("windChillTemperature")]
    public ApparentTemperatureResponse WindChillTemperature { get; set; }

    [JsonPropertyName("wetBulbTemperature")]
    public ApparentTemperatureResponse WetBulbTemperature { get; set; }

    [JsonPropertyName("precipitationSummary")]
    public Dictionary<string, ApparentTemperatureResponse> PrecipitationSummary { get; set; }

    [JsonPropertyName("temperatureSummary")]
    public TemperatureSummaryResponse TemperatureSummary { get; set; }
}