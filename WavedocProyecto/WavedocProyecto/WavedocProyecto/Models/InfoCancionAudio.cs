using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace WaveDock_Xamarin.Models
{
    public class InfoCancionAudio
    {
        [JsonProperty("count")]
        public String count { get; set; }

        [JsonProperty("list")]
        public List<ListaResultadoAudio> list { get; set; }
      
    }
}
