using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class AddressResultResponse
{
    [JsonPropertyName("type")] public string Type { get; set; }

    [JsonPropertyName("id")] public string Id { get; set; }

    [JsonPropertyName("score")] public double Score { get; set; }

    [JsonPropertyName("entityType")] public string EntityType { get; set; }

    [JsonPropertyName("address")] public AddressResponse Address { get; set; }

    [JsonPropertyName("position")] public PositionResponse Position { get; set; }

    [JsonPropertyName("viewport")] public BoundingBoxResponse Viewport { get; set; }

    [JsonPropertyName("boundingBox")] public BoundingBoxResponse BoundingBox { get; set; }

    [JsonPropertyName("dataSources")] public DataSourcesResponse DataSources { get; set; }

    [JsonPropertyName("info")] public string Info { get; set; }

    [JsonPropertyName("poi")] public PoiResponse Poi { get; set; }

    [JsonPropertyName("entryPoints")] public EntryPointResponse[] EntryPoints { get; set; }
}