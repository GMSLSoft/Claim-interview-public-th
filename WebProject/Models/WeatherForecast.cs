namespace WebProject.Models
{
    public class WeatherForecast
    {
        public readonly WeatherTypeEnum WeatherType;

        public readonly int TemperatureInCelsius;

        public readonly string LocationName;

        public WeatherForecast(
           string locationName,
            WeatherTypeEnum weatherType, 
            int temperatureInCelsius)
        {
            LocationName = locationName;
            WeatherType = weatherType;
            TemperatureInCelsius = temperatureInCelsius;
        }
    }
}
