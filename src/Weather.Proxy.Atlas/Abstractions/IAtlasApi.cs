using Refit;
using Wheater.Proxy.Atlas.Resposes;
using Wheater.Proxy.Atlas.Resposes.SearchAddress;

namespace Wheater.Proxy.Atlas;

public interface IAtlasApi
{
    [Get("/weather/currentConditions/json?api-version=1.0&query={query}&subscription-key={subscriptionKey}")]
    Task<WeatherConditionResultsResponse> GetCurrentWeatherCondition(string query, string subscriptionKey, CancellationToken cancellationToken = default);
    
    [Get("/search/fuzzy/json?&api-version=1.0&subscription-key={subscriptionKey}&language=pt-BR&query={query}")]
    Task<SearchAddressResponse> SearchAddressAsync(string query, string subscriptionKey, CancellationToken cancellationToken = default);
}