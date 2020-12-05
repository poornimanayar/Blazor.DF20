using System;

namespace Blazor.DF20.Shared.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ReleaseYear { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
