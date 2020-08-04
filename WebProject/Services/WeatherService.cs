using System;
using System.Linq;
using WebProject.Models;

namespace WebProject.Services
{
    public interface IWeatherService
    {
        WeatherForecast GetTodaysForecast(string locationName);
    }

    public class WeatherService : IWeatherService
    {
        private readonly Random random;

        public WeatherService(Random random)
        {
            this.random = random;
        }

        public WeatherForecast GetTodaysForecast(string locationName)
        {
            var values = Enum.GetValues(typeof(WeatherTypeEnum)).OfType<WeatherTypeEnum>().ToArray();
            var randomWeather = values[random.Next(values.Length)];
            var randomTemperature = random.Next(-10, 40);

            return new WeatherForecast(
                locationName,
                randomWeather,
                randomTemperature);
        }
    }
}