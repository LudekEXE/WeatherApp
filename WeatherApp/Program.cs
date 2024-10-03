using Microsoft.Extensions.DependencyInjection;
using WeatherApp;



var servicePrivider = new ServiceCollection()
    .AddHttpClient()
    .AddSingleton<IWeatherService, WeatherService>()
    .BuildServiceProvider();
    
    var weatherService = servicePrivider.GetService<IWeatherService>();
    
    Console.WriteLine("Podaj miejscowosc");
    var location = Console.ReadLine();

    if (location != null)
    {
        var weather = await weatherService?.GetWeatherAsync(location)!;
        if (weather != null)
        {
            Console.WriteLine($"Temperatura: {weather.Temp}°C");
            Console.WriteLine($"Wilgotność: {weather.Humidity}%");
            Console.WriteLine($"Ciśnienie: {weather.Pressure} hPa");
            Console.WriteLine($"Opis: {weather.Condition}");
        }
    }