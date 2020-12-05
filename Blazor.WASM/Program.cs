using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazor.WASM.Services;

namespace Blazor.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient<IGenreService, GenreService>(c => c.BaseAddress = new Uri("https://localhost:44334/"));
            builder.Services.AddHttpClient<IMovieService, MovieService>(c => c.BaseAddress = new Uri("https://localhost:44334/"));

            await builder.Build().RunAsync();
        }
    }
}
