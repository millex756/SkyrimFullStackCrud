using SkyrimFullStack.Client.Services.SavedDataService;
using SkyrimFullStackCrud.Shared;
using System.Net.Http.Json;

namespace SkyrimFullStack.Client.Services.SavedDataService
{
    public class SavedDataService : ISavedDataService
    {
        private readonly HttpClient _http;

        public SavedDataService(HttpClient http)
        {
            _http = http;
        }

        public List<Player> players { get; set; } = GetPlayers();

        public Task<Player> GetPlayer(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetPlayers()
        {
            List<Player> result = await _http.GetFromJsonAsync<List<Player>>("api/player");
            if (result != null)
                players = result;
        }
    }
}
