using Newtonsoft.Json;

namespace EarthQuakes.Models
{
    public class Feature
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

}
