namespace WeatherApp;

public class WeatherInfo(string city, string country, double temp, double humidity, double pressure, string condition)
{
    public string City { get; set; } = city;
    public string Country { get; set; } = country;
    public double Temp { get; set; } = temp;
    public double Humidity { get; set; } = humidity;
    public double Pressure { get; set; } = pressure;
    public string Condition { get; set; } = condition;
}
