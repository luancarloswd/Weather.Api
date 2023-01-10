using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Weather.Proxy.ViaCep;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddViaCepApi(this IServiceCollection services, IConfiguration configuration, string configSection = "ViaCep:Url")
    {
        var viaCepUlr = configuration.GetSection(configSection).Value;
        if (string.IsNullOrEmpty(viaCepUlr)) return services;
        services.AddRefitClient<IViaCepApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(viaCepUlr));
        return services;
    }
}