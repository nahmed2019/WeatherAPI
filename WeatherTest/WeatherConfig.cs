using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WeatherWrapperTest
{
    public static class WeatherConfig
    {
        public static readonly String BaseUrl = ConfigurationManager.AppSettings["baseURL"];
        public static readonly String ApiKey = ConfigurationManager.AppSettings["api_key"];
        public static readonly String ApiUriMod = ConfigurationManager.AppSettings["access_key_url_mod"];
    }
}
