using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPrimer_Challenge_2
{
    class WeatherData
    {
        public WeatherData(int t, int h, string s)
        {
            Temperature = t;
            Humidity = h;
            Scale = s;
        }

        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public string Scale { get; set; }
            
        public void Celsius()
        {
            Scale = "C";
        }
        public void Fahrenheit()
        {
            Scale = "F";
        }
}
}
