using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaveDock_Xamarin.Models
{
    public class Media
    {
        [JsonProperty("provider")]
        public String provider { get; set; }

        [JsonProperty("url")]
        public String url { get; set; }

        
        [JsonProperty("start")]
        public String start { get; set; }

        [JsonProperty("video")]
        public String video { get; set; }

        [JsonProperty("type")]
        public String type { get; set; }

         [JsonProperty("provider_id")]
        public String provider_id { get; set; }
        
        [JsonProperty("native_uri")]
        public String native_uri { get; set; }
        

    }
}
