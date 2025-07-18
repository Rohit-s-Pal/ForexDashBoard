using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using ForexGUI.Models;

namespace ForexAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }




        [HttpPost("Authentication")]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.EmailId == "test@example.com" && model.Password == "12345")
            {
                return Ok(new
                {
                    success = true,
                   
                    redirectUrl = "/AdminDashboard/AdminDashboard"
                });
            }
            return Unauthorized(new { success = false, message = "Invalid username or password" });
        }



    }
}
