using Blazor.DF20.Shared.Models;
using Blazor.DF20.WASM.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DF20.WASM.Components
{
    public partial class QuickAddMovie
    {
        [Inject]
        public IMovieService movieService { get; set; }

        [Parameter]
        public EventCallback<bool> AddMovieEventCallBack { get; set; }

        public Movie Movie { get; set; } = new Movie();

        public async Task AddMovie()
        {
            await movieService.AddMovie(Movie);
            await AddMovieEventCallBack.InvokeAsync(true);
        }
    }
}
