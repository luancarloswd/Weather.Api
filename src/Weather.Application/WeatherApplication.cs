using Weather.Application.Abstractions;
using Weather.Proxy.ViaCep;
using Wheater.Proxy.Atlas.Abstractions;

namespace Weather.Application;

public class WeatherApplication : IWeatherApplication
{
    private readonly IViaCepApi _viaCepApi;
    private readonly IAtlasProxy _atlasProxy;

    public WeatherApplication(IViaCepApi viaCepApi, IAtlasProxy atlasProxy)
    {
        _viaCepApi = viaCepApi;
        _atlasProxy = atlasProxy;
    }

    public async Task<Domain.Weather?> GetByPostalCodeAsync(string postalCode, CancellationToken cancellationToken = default)
    {
        var location = await _viaCepApi.SearchPostalCodeAsync(postalCode, cancellationToken);
        var query = $"{location.Place} {location.Location} {location.Uf}";

        var position = await _atlasProxy.SearchPosition(query, cancellationToken);
        if (position != null)
            return await _atlasProxy.GetWeatherAsync(position, cancellationToken);
        
        return default;
    }
}