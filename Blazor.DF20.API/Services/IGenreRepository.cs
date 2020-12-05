using System.Collections.Generic;
using Genre = Blazor.DF20.API.Models.Genre;

namespace Blazor.DF20.API.Services
{
   public interface IGenreRepository
    {
        IEnumerable<Genre> GetAllGenres();

        Genre GetGenreById(int genreId);
    }
}
