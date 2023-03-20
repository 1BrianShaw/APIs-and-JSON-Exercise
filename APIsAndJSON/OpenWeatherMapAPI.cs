using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    class OpenWeatherMapAPI
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var apiKey = "64ab2cb3ebfb34e5ef9245fea3413214";
            Console.WriteLine("Enter in a city: ");
            var cityName = Console.ReadLine();

            var weatherMapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
            string weatherResponse = client.GetStringAsync(weatherMapURL).Result;
            JObject weatherObject = JObject.Parse(weatherResponse);

            Console.WriteLine("Weather Object");

            
            
        }













    }
}
