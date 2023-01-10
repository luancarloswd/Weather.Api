using Microsoft.AspNetCore.Mvc;
using Refit;
using Weather.Application.Abstractions;

namespace Weather.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class WeatherController : Controller
{
    private readonly IWeatherApplication _application;

    public WeatherController(IWeatherApplication application) => _application = application;

    [Route("{postalCode}")]
    [Get("")]
    public async Task<IActionResult> GetAsync(string postalCode, CancellationToken cancellationToken = default)
    {
        var weather = await _application.GetByPostalCodeAsync(postalCode, cancellationToken);
        if (weather == default) return NoContent();
        return Ok(weather);
    }
}