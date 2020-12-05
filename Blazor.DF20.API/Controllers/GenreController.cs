using Blazor.DF20.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.DF20.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepository _genreService;

        public GenreController(IGenreRepository genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        public IActionResult GetGenres()
        {
            return Ok(_genreService.GetAllGenres());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult GetGenreById(int id)
        {
            return Ok(_genreService.GetGenreById(id));
        }
    }
}
