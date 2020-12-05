using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.WASM.Models;
using Blazor.WASM.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor.WASM.Components
{
    public partial class QuickAddMovie
    {
        [Inject]
        public IMovieService movieService { get; set; }

        [Inject]
        public IGenreService genreService { get; set; }

        [Parameter]
        public EventCallback<bool> AddMovieEventCallBack { get; set; }

        public string MovieName { get; set; }

        public int Genre { get; set; }

        private MovieDTO movie = new MovieDTO();

        public List<GenreDTO> Genres { get; set; } = new List<GenreDTO>();

        public string MovieNameKeyPress { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> MyCodeGeneratedAttributes { get; set; } = new Dictionary<string, object>(){{ "min", 1960 },{"max",2025} };

        protected override async Task OnInitializedAsync()
        {
            Genres = (await genreService.GetAllGenres()).ToList();
            
        }

        public async Task AddMovie()
        {
            await movieService.AddMovie(movie);
            await AddMovieEventCallBack.InvokeAsync(true);
            movie = new MovieDTO();
        }
    }
}
