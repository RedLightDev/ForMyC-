using System;
using System.Linq;

namespace BS_Start.Repository
{
    public class WeatherForecastRepository
    {
        //ANY DATABASE ACCESS WILL BE FROM THESE TYPE OF CLASSES
        private static readonly string[] Summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
        public WeatherForecastRepository()
        {
        }


        public WeatherForecast[] GetAll()
        {
            var rng = new Random();
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
                .ToArray();
            return result;
        }


    }
}
