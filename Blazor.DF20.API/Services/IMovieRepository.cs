using System.Collections.Generic;
using Movie = Blazor.DF20.API.Models.Movie;

namespace Blazor.DF20.API.Services
{
  public  interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovieById(int movieId);
        Movie AddMovie(Movie movie);
        Movie UpdateMovie(Movie movie);
        void DeleteMovie(int movieId);
    }
}
