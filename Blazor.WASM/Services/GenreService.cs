using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Blazor.WASM.Models;

namespace Blazor.WASM.Services
{
    public class GenreService : IGenreService
    {
        private readonly HttpClient _httpClient;

        public GenreService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<GenreDTO>> GetAllGenres()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<GenreDTO>>(await _httpClient.GetStreamAsync($"api/genre"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<GenreDTO> GetGenreById(int genreId)
        {
            return await JsonSerializer.DeserializeAsync<GenreDTO>(await _httpClient.GetStreamAsync($"api/genre/{genreId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
