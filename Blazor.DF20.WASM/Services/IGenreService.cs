using Blazor.DF20.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DF20.WASM.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetAllGenres();

        Task<Genre> GetGenreById(int genreId);
    }
}
