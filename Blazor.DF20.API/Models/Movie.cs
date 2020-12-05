namespace Blazor.DF20.API.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ReleaseYear { get; set; }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
