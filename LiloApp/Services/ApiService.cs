using LiloApp.Models;
using Newtonsoft.Json;

namespace LiloApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Dream>> GetDreamsAsync()
        {
            var response = await _httpClient.GetAsync("https://liloapp-backend.onrender.com/dreams");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Dream>>(json);
            }

            return new List<Dream>();
        }
    }
}
