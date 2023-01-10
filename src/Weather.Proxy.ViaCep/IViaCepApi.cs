using Refit;
using Weather.Proxy.ViaCep.Responses;

namespace Weather.Proxy.ViaCep;

public interface IViaCepApi
{
    [Get("/ws/{postalCode}/json/")]
    Task<CepResponse> SearchPostalCodeAsync(string postalCode, CancellationToken cancellationToken = default);
}