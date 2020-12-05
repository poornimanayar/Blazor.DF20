using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Blazor.WASM.Models;

namespace Blazor.WASM.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _httpClient;

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MovieDTO> AddMovie(MovieDTO movie)
        {
            var movieJson = new StringContent(JsonSerializer.Serialize(movie), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/movie", movieJson);
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<MovieDTO>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteMovie(int movieId)
        {
            await _httpClient.DeleteAsync("api/movie/{movieId}");
        }

        public async Task<IEnumerable<MovieDTO>> GetAllMovies()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<MovieDTO>>(await _httpClient.GetStreamAsync($"api/movie"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<MovieDTO> GetMovieDetails(int movieId)
        {
            return await JsonSerializer.DeserializeAsync<MovieDTO>(await _httpClient.GetStreamAsync($"api/movie/{movieId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<MovieDTO> UpdateMovie(MovieDTO movie)
        {
            var movieJson = new StringContent(JsonSerializer.Serialize(movie), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/movie", movieJson);
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<MovieDTO>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }
    }
}
