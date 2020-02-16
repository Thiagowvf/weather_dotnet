using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using weather_dotnet.Models;
using weather_dotnet.Services;

namespace weather_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class weatherController : Controller
    {
        private readonly WeatherHqServices _weather;
        public weatherController(WeatherHqServices weather)
        {
            _weather = weather;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public System.Threading.Tasks.Task<Weather> Get()
        {
            return _weather.GetTemperatureMaxAsync();
        }
    }
}