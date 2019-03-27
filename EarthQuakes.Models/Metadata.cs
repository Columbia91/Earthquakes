using Newtonsoft.Json;

namespace EarthQuakes.Models
{
    public class Metadata
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
