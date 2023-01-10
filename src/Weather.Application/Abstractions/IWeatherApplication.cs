namespace Weather.Application.Abstractions;

public interface IWeatherApplication
{
    Task<Domain.Weather?> GetByPostalCodeAsync(string postalCode, CancellationToken cancellationToken = default);
}