using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Windows.Shared;

namespace WpfScheduler.Model
{
    public class WeatherModel
    {
        public string weather;
        public double wind;
        public double temp;
        public DateTime from;
        public DateTime to;

        public WeatherModel(string weather, double wind, double temp, DateTime from, DateTime to)
        {
            this.weather = weather;
            this.wind = wind;
            this.temp = temp;
            this.from = from;
            this.to = to;
        }

        public int IsGoodWeather()
        {
            if (weather != "Rain" || wind < 5.00 || temp - 273.15 < 23)
            {
                return -1;
            }

            return 1;
        }
    }
}
