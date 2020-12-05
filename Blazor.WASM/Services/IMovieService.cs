using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.WASM.Models;

namespace Blazor.WASM.Services
{
   public interface IMovieService
    {
        Task<IEnumerable<MovieDTO>> GetAllMovies();

        Task<MovieDTO> GetMovieDetails(int movieId);

        Task<MovieDTO> AddMovie(MovieDTO movie);

        Task<MovieDTO> UpdateMovie(MovieDTO movie);

        Task DeleteMovie(int movieId);
    }
}
