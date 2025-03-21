using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10_1
{
    public enum WeatherType
    {
        SUNNY = 0,
        CLOUDY,
        WINDY,
        RAINING,
        SNOWING,
        HAILING,
        FOGGY
    }
    public class Weather
    {
        public string City { get; set; }
        public WeatherType Type { get; set; }
        public int Temperature { get; set; }
        public string WindLevel { get; set; }
    }
}
