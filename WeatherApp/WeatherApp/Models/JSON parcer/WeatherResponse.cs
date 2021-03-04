using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Models.JSON_parcer
{
    class WeatherResponse
    {
        public TemperatureInfo Main { get; set; }

        public string Name { get; set; }
    }
}
