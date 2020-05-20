using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaveDock_Xamarin.Models
{
    public class InfoCancionLetra
    {
        /*public InfoCancionLetra()
        {
            this.media = new List<Media>();
            String xx = "[{\"provider\":\"soundcloud\",\"type\":\"audio\",\"url\":\"https:\\/\\/soundcloud.com\\/jahseh-onfroy\\/up-like-an-insomniac-freestyleprod-xxxtentacion-ronny-j\"},{\"provider\":\"youtube\",\"start\":0,\"type\":\"video\",\"url\":\"http:\\/\\/www.youtube.com\\/watch?v=TLb98hNfAng\"}]";
            //JArray xd = (JArray)JsonConvert.DeserializeObject(this.mediaPre);
            try
            {
                JArray s = JArray.Parse(xx);
                this.media = s.ToObject<List<Media>>();
            } catch (Exception e){
                Console.WriteLine(e);
            }
        }*/

        [JsonProperty("song_id")]
        public String song_id { get; set; }

        [JsonProperty("artist_id")]
        public String artist_id { get; set; }

        [JsonProperty("title")]
        public String title { get; set; }

        [JsonProperty("title_with_featured")]
        public String title_with_featured { get; set; }

        [JsonProperty("full_title")]
        public String full_title { get; set; }

        [JsonProperty("artist")]
        public String artist { get; set; }

        [JsonProperty("lyrics")]
        public String lyrics { get; set; }

        [JsonProperty("media")]
        public String mediaPre { get; set; }
        

        [JsonIgnore]
        public List<Media> media { get; set; }
        
  
       

    }
}
