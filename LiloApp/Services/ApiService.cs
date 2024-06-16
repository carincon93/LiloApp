using LiloApp.Data;
using Newtonsoft.Json;
using System.Text;

namespace LiloApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<DreamData>> GetDreamsAsync()
        {
            var response = await _httpClient.GetAsync("https://liloapp-backend.onrender.com/dreams");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<DreamData>>(json);
            }

            return new List<DreamData>();
        }
        
        public async Task<bool> AddDreamAsync(DreamData newDream)
        {
            var json = JsonConvert.SerializeObject(newDream);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://liloapp-backend.onrender.com/dreams", content);
            return response.IsSuccessStatusCode;
        }
    }
}
