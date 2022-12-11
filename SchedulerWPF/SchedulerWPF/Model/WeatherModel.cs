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
