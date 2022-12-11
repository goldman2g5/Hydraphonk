using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WpfScheduler.Model;

namespace WpfScheduler.Misc
{
    static class WeatherProvider
    {
        private static Random r = new Random();
        //public static List<WeatherModel> WeekForecast()
        //{
        //    foreach (var VARIABLE in null)
        //    {
                
        //    }
        //};


        //public static WeatherModel GetRandomToday()
        //{
        //    return new WeatherModel()
        //    {
        //        weather = r.Next(0, 5) == 0 ? "Rain" : "NotRain";
        //        wind = r.Next(0, 5) == 0 ? "";
        //    }
        //}

        //public static WeatherModel GetActualToday()
        //{
        //    string url = "https://api.openweathermap.org/data/2.5/weather?lat=55.7504461&lon=37.6174943&appid=2171ec830f4958585f27f7f258b72e98";
        //    Dictionary<string, string> json = new Dictionary<string, string>();
        //    using (WebClient wc = new WebClient()) 
        //    { 
        //        json = JsonConvert.DeserializeObject<Dictionary<string, string>>(wc.DownloadString(url));
        //    }

        //    return new WeatherModel()
        //    {
        //        weather = json.TryGetValue()
        //    };

        //}
    }
}
