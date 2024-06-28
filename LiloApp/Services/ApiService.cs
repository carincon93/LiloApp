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

        public async Task<List<EnglishWordData>> GetEnglishWordsByWeekAsync(string week)
        {
            var response = await _httpClient.GetAsync($"https://liloapp-backend.onrender.com/english-words/week/{week}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<EnglishWordData>>(json);
            }

            return new List<EnglishWordData>();
        }

        public async Task<List<ItalianWordData>> GetItalianWordsByWeekAsync(string week)
        {
            var response = await _httpClient.GetAsync($"https://liloapp-backend.onrender.com/italian-words/week/{week}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItalianWordData>>(json);
            }

            return new List<ItalianWordData>();
        }
    }
}
