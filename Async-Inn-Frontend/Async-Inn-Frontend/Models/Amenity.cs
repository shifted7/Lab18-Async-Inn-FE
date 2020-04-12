using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Async_Inn_Frontend.Models
{
    public class Amenity
    {
        [JsonPropertyName("iD")]
        public int ID { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }

        //public IEnumerator<AmenitiesDTO> GetEnumerator()
        //{
        //    return null;
        //}
    }
}
