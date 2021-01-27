using System;

namespace WpfApp14
{
    class Weather
    {
        public string Temp { get; set; }
        public Uri Image { get; set; }
        public string WeatherType { get; set; }

        public Weather( string temp, string url, string weatherType)
        {
            Temp = temp;
            Image = new Uri(url);
            WeatherType = weatherType;
        }
    }
}
