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

        public string MovieName { get; set; }

        public string MovieNameKeyPress { get; set; }

        public async Task AddMovie()
        {
            await movieService.AddMovie(new Movie() { Name = MovieName });
            await AddMovieEventCallBack.InvokeAsync(true);
        }
    }
}
