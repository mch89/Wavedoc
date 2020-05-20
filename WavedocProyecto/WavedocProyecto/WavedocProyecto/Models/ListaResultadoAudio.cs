
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaveDock_Xamarin.Models
{
    public class ListaResultadoAudio
    {

        [JsonProperty("score")]
        public String score { get; set; }

        [JsonProperty("artist")]
        public String artist { get; set; }

        [JsonProperty("title")]
        public String title { get; set; }
    }
}
