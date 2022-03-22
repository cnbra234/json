using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace json
{
    public class Program
    {
        public static void Main()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            var PheonixForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2022-22-03"),
                TemperatureCelsius = 28,
                Summary = "warm"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);

            WriteLine(jsonString);

            string Pheonix = JsonSerializer.Serialize(PheonixForecast);
            WriteLine(Pheonixstirng);

            weatherForecast w = JsonSerializer.Deserialize<WeatherForecast>(Pheonix);
            WriteLine(w.summary);

            ReadKey();
        }
    }
}
