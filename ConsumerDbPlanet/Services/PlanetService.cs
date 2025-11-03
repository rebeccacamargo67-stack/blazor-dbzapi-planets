using System.Net.Http.Json;
using ConsumerDbPlanet.Models;

namespace ConsumerDbPlanet.Services
{
    public class PlanetService
    {
        private readonly HttpClient _http;

        public PlanetService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Planet?> GetPlanetByIdAsync(int id)
        {
            try
            {
                var url = $"https://dragonball-api.com/api/planets/{id}";
                return await _http.GetFromJsonAsync<Planet>(url);
            }
            catch
            {
                return null;
            }
        }
    }
}
