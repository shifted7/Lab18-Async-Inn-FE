using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Async_Inn_Frontend.Models
{
    public class Room
    {
        [JsonPropertyName("iD")]
        public int ID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("layout")]
        public string Layout { get; set; }

        [JsonPropertyName("amenities")]
        public List<Amenity> Amenities { get; set; }
    }
}
