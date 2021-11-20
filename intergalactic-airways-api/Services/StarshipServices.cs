using intergalactic_airways_api.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace intergalactic_airways_api.Services
{
    public class StarshipServices
    {
        const string STARSHIP_URL = "https://swapi.dev/api/starships/";
        public static async Task<List<Starship>> GetStarships(int passengerCount)
        {
            List<Starship> lstStarships = new List<Starship>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(STARSHIP_URL);
                var result = await response.Content.ReadAsStringAsync();
                StarshipObjectRequest temp = JsonConvert.DeserializeObject<StarshipObjectRequest>(result);

                lstStarships = temp.ListStarships.Where(ships => ships.PassengerCount >= passengerCount).ToList();

                if (lstStarships.Count > 0)
                {
                    foreach (var ships in lstStarships)
                    {
                        List<Pilot> lstPilots = new List<Pilot>();
                        if (ships.Pilots.Length > 0) { 
                            foreach (var url in ships.Pilots)
                            {
                                var pilotResponse = await client.GetAsync(url);
                                var res = await pilotResponse.Content.ReadAsStringAsync();
                                var pilotInfo = JsonConvert.DeserializeObject<Pilot>(res);
                                lstPilots.Add(pilotInfo);
                            }
                            ships.Pilots = lstPilots.Select(p => p.Name).ToArray();
                        }
                    }
                }
            }

            return lstStarships;
        }
    }
}
