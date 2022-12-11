using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WpfScheduler.Model;

namespace WpfScheduler.Misc
{
    static class WeatherProvider
    {
        private static Random r = new Random();
        public static List<WeatherModel> WeekForecast()
        {
            List<WeatherModel> result = new List<WeatherModel>();
            int plus_days = 0;
            foreach (var i in Enumerable.Range(1, 6))
            {
                
            }

                return result;
        }


        public static WeatherModel GetRandomToday(int plus_days=0)
        {
            string weather = r.Next(0, 5) == 0 ? "Rain" : "NotRain";
            double wind = r.Next(0, 5) == 0 ? 5.10 : 3.00;
            double temp = r.Next(0, 5) == 0 ? 23 : 18;
            DateTime from = DateTime.Now.AddHours(r.Next(0, 3)).AddMinutes(r.Next(0, 60)).AddDays(plus_days);
            DateTime to = from.AddHours(r.Next(0, 3)).AddMinutes(r.Next(0, 60));
            return new WeatherModel(weather, wind, temp, from, to);
        }
    }

    //public static WeatherModel GetActualToday()
    //{
    //    var client = new HttpClient();
    //    var userURL = "https://api.openweathermap.org/data/2.5/weather?lat=55.7504461&lon=37.6174943&appid=2171ec830f4958585f27f7f258b72e98";
    //    var weatherResponse = client.GetStringAsync(userURL).Result;
    //    var formattedResponseMain = JObject.Parse(weatherResponse).GetValue("main").ToString();
    //    var formattedResponseTemp = JObject.Parse(formattedResponseMain).GetValue("temp").ToString();

    //    Console.WriteLine($"\n{formattedResponseTemp} degrees Fahrenheit.");

    //}
}
