using System.Collections.Generic;
using BS_Start.Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BS_Start.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastDomain _domain = new WeatherForecastDomain();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        /// <param name="id"></param>     
        [HttpGet]
        public IEnumerable<WeatherForecast> Get(int Id)
        {
            return _domain.GetIfAllowed(Id);
        }
    }
}
