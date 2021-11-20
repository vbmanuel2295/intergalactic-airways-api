using Newtonsoft.Json;
using System.Collections.Generic;

namespace intergalactic_airways_api.Models
{
    public class Starship
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonIgnore]
        public int PassengerCount { get; set; }
        [JsonProperty("pilots")]
        public string[] Pilots { get; set; }
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("starship_class")]
        public string StarshipClass { get; set; }

        /// <summary>
        /// Gets or sets the passengers count as string.
        /// </summary>
        [JsonProperty("passengers")]
        private string _passengers
        {
            get 
            {
                return _passengers;
            }
            set
            {
                if (value != null && value != "n/a" && int.TryParse(value, out int count))
                    PassengerCount = count;
                else
                    PassengerCount = 0;
            }
        }
    }
}