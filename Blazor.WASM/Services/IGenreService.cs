using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.WASM.Models;

namespace Blazor.WASM.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreDTO>> GetAllGenres();

        Task<GenreDTO> GetGenreById(int genreId);
    }
}
