using System.Collections.Generic;
using System.Linq;
using Movie = Blazor.DF20.API.Models.Movie;

namespace Blazor.DF20.API.Services
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviesDbContext _moviesDbContext;

        public MovieRepository(MoviesDbContext moviesDbContext)
        {
            _moviesDbContext = moviesDbContext;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _moviesDbContext.Movies;//.Include(m => m.Genre);
        }

        public Movie GetMovieById(int movieId)
        {
            return _moviesDbContext.Movies.FirstOrDefault(m =>m.Id == movieId) ;
        }

        public Movie AddMovie(Movie movie)
        {
            var addedEntity = _moviesDbContext.Movies.Add(movie);
            _moviesDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Movie UpdateMovie(Movie movie)
        {
            var movieToEdit = _moviesDbContext.Movies.FirstOrDefault(m => m.Id == movie.Id);

            if (movieToEdit != null)
            {
                movieToEdit.GenreId = movie.GenreId;
                movieToEdit.Name = movie.Name;
                movieToEdit.ReleaseYear = movie.ReleaseYear;

                _moviesDbContext.SaveChanges();

                return movieToEdit;
            }

            return null;
        }

        public void DeleteMovie(int movieId)
        {
            var movieToDelete = _moviesDbContext.Movies.FirstOrDefault(m => m.Id == movieId);

            if(movieToDelete == null)
            {
                return;
            }

            _moviesDbContext.Movies.Remove(movieToDelete);
            _moviesDbContext.SaveChanges();
        }
    }
}
