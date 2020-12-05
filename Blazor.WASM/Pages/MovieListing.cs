using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.WASM.Components;
using Blazor.WASM.Models;
using Blazor.WASM.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor.WASM.Pages
{
    public partial class MovieListing
    {
        [Inject]
        public IMovieService movieService { get;set; }

        protected QuickAddMovie QuickAddMovieForm { get; set; }

        private IEnumerable<MovieDTO> Movies { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Movies = await movieService.GetAllMovies();
        }

        public async Task QuickAddMovieForm_CallbackAsync()
        {
            Movies = await movieService.GetAllMovies();
            StateHasChanged();
        }
    }
}
