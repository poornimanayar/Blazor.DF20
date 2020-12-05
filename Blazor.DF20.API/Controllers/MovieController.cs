using Blazor.DF20.API.Services;
using Microsoft.AspNetCore.Mvc;
using Movie = Blazor.DF20.API.Models.Movie;

namespace Blazor.DF20.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieService)
        {
            _movieRepository = movieService;
        }


        [HttpGet]
        public IActionResult GetAllMovies()
        {
            return Ok(_movieRepository.GetAllMovies());
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            return Ok(_movieRepository.GetMovieById(id));
        }

        [HttpPost]
        public IActionResult CreateMovie([FromBody] Movie movie)
        {
            if (movie == null)
                return BadRequest();

            var createdMovie = _movieRepository.AddMovie(movie);

            return Created("Movie", createdMovie);
        }

        [HttpPut]
        public IActionResult UpdateMovie([FromBody] Movie movie)
        {
            if (movie == null)
                return BadRequest();

            

            var movieToUpdate = _movieRepository.GetMovieById(movie.Id);

            if (movieToUpdate == null)
                return NotFound();

            _movieRepository.UpdateMovie(movie);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            if (id == 0)
                return BadRequest();

            var movieToDelete = _movieRepository.GetMovieById(id);
            if (movieToDelete == null)
                return NotFound();

            _movieRepository.DeleteMovie(id);

            return NoContent();//success
        }
    }
}
