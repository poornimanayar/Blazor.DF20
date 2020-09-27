using Blazor.DF20.Shared.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blazor.DF20.WASM.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _httpClient;

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Movie> AddMovie(Movie movie)
        {
            var movieJson = new StringContent(JsonSerializer.Serialize(movie), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/movie", movieJson);
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Movie>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteMovie(int movieId)
        {
            await _httpClient.DeleteAsync("api/movie/{movieId}");
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Movie>>(await _httpClient.GetStreamAsync($"api/movie"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Movie> GetMovieDetails(int movieId)
        {
            return await JsonSerializer.DeserializeAsync<Movie>(await _httpClient.GetStreamAsync($"api/movie/{movieId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            var movieJson = new StringContent(JsonSerializer.Serialize(movie), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/movie", movieJson);
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Movie>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }
    }
}
