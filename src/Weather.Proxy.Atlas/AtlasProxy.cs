using System.Globalization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Weather.Domain;
using Wheater.Proxy.Atlas.Abstractions;

namespace Wheater.Proxy.Atlas;

public class AtlasProxy : IAtlasProxy
{
    private readonly AtlasConfiguration _config;
    private readonly IAtlasApi _atlasApi;

    public AtlasProxy(IOptions<AtlasConfiguration> options, IAtlasApi atlasApi)
    {
        _atlasApi = atlasApi;
        _config = options.Value;
    }

    public async Task<Weather.Domain.Weather?> GetWeatherAsync(Position position, CancellationToken cancellationToken = default)
    {
        var result = await _atlasApi.GetCurrentWeatherCondition($"{position.Latitude.ToString(CultureInfo.InvariantCulture)},{position.Longitude.ToString(CultureInfo.InvariantCulture)}", _config.SubscriptionKey, cancellationToken);
        var betterResult = result.Results.FirstOrDefault();
        if (betterResult == default) return default;
        return new Weather.Domain.Weather
        {
            Description = betterResult.Phrase,
            Temperature = betterResult.Temperature.Value
        };
    }

    public async Task<Position?> SearchPosition(string location, CancellationToken cancellationToken = default)
    {
        var result = await _atlasApi.SearchAddressAsync(location, _config.SubscriptionKey, cancellationToken);
        var betterResult = result.Results.MaxBy(r => r.Score);
        
        if (betterResult == default) return default;
        
        return new Position
        {
            Latitude = betterResult.Position.Lat,
            Longitude = betterResult.Position.Lon
        };
    }
}