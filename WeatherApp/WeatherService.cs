using Newtonsoft.Json;

namespace WeatherApp;

public class WeatherService : IWeatherService
{
    private HttpClient _httpClient;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherInfo?> GetWeatherAsync(string? location)
    {
        var url =$"http://api.weatherapi.com/v1/forecast.json?key=43e523dbd16645bbb4b101505240310&q=Rzeszów&days=1&aqi=no&alerts=no";
        var response = await _httpClient.GetStringAsync(url);
        var weatherData = JsonConvert.DeserializeObject<WeatherInfo>(response);
        return weatherData;
    }
}
