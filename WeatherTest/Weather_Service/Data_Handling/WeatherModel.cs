using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWrapperTest.Weather_Service.Data_Handling
{
    public class ApiRoot
    {
        public coord Coord { set; get; }
        public weather Weather { set; get; }
        public @main @Main { set; get; }
        public wind Wind { set; get; }
        public clouds Clouds { set; get; }
        public sys Sys { set; get; }
        public string @base { set; get; }
        public double visibility { set; get; }
        public int dt { set; get; }
        public int timezone { set; get; }
        public int id { set; get; }
        public string name { set; get; }
        public int cod { set; get; }

    }
        
        public class coord
    {
        public double lon { get; set; } 
        public double lat { get; set; }

    }

    public class weather
    {
        public int id { get; set; }
        public string @main { get; set; }
        public string description { get; set; } 
        public string icon { get; set; }
    }

    public class @main
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }
    
    public class wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
        public double gust { get; set; }

    }
    public class clouds
    {
        public double all { get; set; }
        
    }
    public class sys
    {
        public double type { get; set; }
        public int id { get; set; }
        public double message { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }

    }
   


}
