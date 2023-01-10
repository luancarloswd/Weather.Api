using Microsoft.Extensions.DependencyInjection;
using Weather.Application.Abstractions;

namespace Weather.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services) => 
        services.AddSingleton<IWeatherApplication, WeatherApplication>();
}