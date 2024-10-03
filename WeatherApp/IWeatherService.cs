namespace WeatherApp;

public interface IWeatherService
{
    Task<WeatherInfo?> GetWeatherAsync (string? location);
}