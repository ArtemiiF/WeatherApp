using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using WeatherApp.Models.JSON_parcer;

namespace WeatherApp.Models
{
    class JSONWeather
    {
        public string JSONCityCurrTemp(string cityName)
        {
            string apikey = "765db636a77fb4029456663af384cdb8";
            string apiurl = "http://api.openweathermap.org/data/2.5/weather?q="+cityName+"&units=metric&appid=" + apikey;

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(apiurl);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            

            return weatherResponse.Main.Temp.ToString();
        }

        
    }
}
