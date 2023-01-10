using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using Wheater.Proxy.Atlas.Abstractions;

namespace Wheater.Proxy.Atlas;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAtlasProxy(this IServiceCollection services, IConfiguration configuration, string configSection = "AtlasConfiguration")
    {
        var config = configuration.GetSection(configSection);
        services.Configure<AtlasConfiguration>(config);
        services.AddRefitClient<IAtlasApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(config.GetValue<string>("Url")));

        services.AddSingleton<IAtlasProxy, AtlasProxy>();

        return services;
    } 
}