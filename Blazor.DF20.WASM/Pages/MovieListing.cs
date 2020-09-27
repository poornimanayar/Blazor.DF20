using Blazor.DF20.Shared.Models;
using Blazor.DF20.WASM.Components;
using Blazor.DF20.WASM.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DF20.WASM.Pages
{
    public partial class MovieListing
    {
        [Inject]
        public IMovieService movieService { get;set; }

        protected QuickAddMovie QuickAddMovieForm { get; set; }

        private IEnumerable<Movie> Movies { get; set; }

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
