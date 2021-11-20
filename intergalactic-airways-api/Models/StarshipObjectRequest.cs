using Newtonsoft.Json;
using System.Collections.Generic;

namespace intergalactic_airways_api.Models
{
    public class StarshipObjectRequest
    {
        [JsonProperty("results")]
        public List<Starship> ListStarships { get; set; }
    }
}
