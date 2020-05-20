using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


#region formato Json
/*{
  "status": "success",
  "result": {
    "artist": "Thundercat",
    "title": "Them Changes",
    "album": "The Beyond / Where the Giants Roam",
    "release_date": "2015-06-22",
    "label": "Brainfeeder",
    "timecode": "00:42",
    "song_link": "https://lis.tn/ThemChanges"
  }
}*/
#endregion
namespace WaveDock_Xamarin.Models
{
    public class otroxd
    {
        [JsonProperty("artist")]
        public String artist { get; set; }

        [JsonProperty("title")]
        public String title { get; set; }

        [JsonProperty("album")]
        public String album { get; set; }

        [JsonProperty("release_date")]
        public String release_date { get; set; }

        [JsonProperty("label")]
        public String label { get; set; }

        [JsonProperty("timecode")]
        public String timecode { get; set; }


        [JsonProperty("song_link")]
        public String song_link { get; set; }
    }
}
