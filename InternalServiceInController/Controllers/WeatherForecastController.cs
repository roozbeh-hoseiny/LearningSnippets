using InternalServiceInController.AppCore;
using Microsoft.AspNetCore.Mvc;

namespace InternalServiceInController.Controllers;

[ApiController]
[Route("[controller]")]
internal class WeatherForecastController : ControllerBase
{
    private readonly WeatherForecastService _weatherForecastService;

    public WeatherForecastController(WeatherForecastService weatherForecastService)
    {
        this._weatherForecastService = weatherForecastService;
    }

    [HttpGet]
    public IEnumerable<WeatherForecastResponse> Get() => this._weatherForecastService.Forecast();
}