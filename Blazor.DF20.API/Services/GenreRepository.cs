using System.Collections.Generic;
using System.Linq;
using Blazor.DF20.Shared.Models;

namespace Blazor.DF20.API.Services
{
    public class GenreRepository : IGenreRepository
    {
        private readonly MoviesDbContext _moviesDbContext;

        public GenreRepository(MoviesDbContext moviesDbContext)
        {
            _moviesDbContext = moviesDbContext;
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _moviesDbContext.Genres;
        }

        public Genre GetGenreById(int genreId)
        {
            return _moviesDbContext.Genres.FirstOrDefault(g => g.Id == genreId);
        }
    }
}
