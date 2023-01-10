using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class BoundingBoxResponse
{
    [JsonPropertyName("topLeftPoint")] public PositionResponse TopLeftPoint { get; set; }

    [JsonPropertyName("btmRightPoint")] public PositionResponse BtmRightPoint { get; set; }
}