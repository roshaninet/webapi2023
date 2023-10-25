using Microsoft.AspNetCore.Mvc;

namespace webapi2023.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "FreezingS", "Shiraz", "Tehran","test", "test2", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public UserController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeathert")]
    public IEnumerable<WeatherForecast> Get()
    {
        Console.WriteLine("Hello3213123321");
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
