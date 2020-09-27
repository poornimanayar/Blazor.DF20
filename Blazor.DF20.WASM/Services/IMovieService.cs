using Blazor.DF20.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DF20.WASM.Services
{
   public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMovies();

        Task<Movie> GetMovieDetails(int movieId);

        Task<Movie> AddMovie(Movie movie);

        Task<Movie> UpdateMovie(Movie movie);

        Task DeleteMovie(int movieId);
    }
}
