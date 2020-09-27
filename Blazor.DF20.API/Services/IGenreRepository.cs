using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.DF20.Shared.Models;

namespace Blazor.DF20.API.Services
{
   public interface IGenreRepository
    {
        IEnumerable<Genre> GetAllGenres();

        Genre GetGenreById(int genreId);
    }
}
