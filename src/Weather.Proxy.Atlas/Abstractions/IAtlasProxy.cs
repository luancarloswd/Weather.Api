using Weather.Domain;

namespace Wheater.Proxy.Atlas.Abstractions;

public interface IAtlasProxy
{
    Task<Weather.Domain.Weather?> GetWeatherAsync(Position position, CancellationToken cancellationToken = default);
    Task<Position?> SearchPosition(string location, CancellationToken cancellationToken = default);
}