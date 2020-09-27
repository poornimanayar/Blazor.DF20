using Blazor.DF20.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blazor.DF20.WASM.Services
{
    public class GenreService : IGenreService
    {
        private readonly HttpClient _httpClient;

        public GenreService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Genre>>(await _httpClient.GetStreamAsync($"api/genre"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Genre> GetGenreById(int genreId)
        {
            return await JsonSerializer.DeserializeAsync<Genre>(await _httpClient.GetStreamAsync($"api/genre/{genreId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
