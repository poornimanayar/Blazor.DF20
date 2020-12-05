using System.ComponentModel.DataAnnotations;

namespace Blazor.WASM.Models
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Movie name is too long")]
        public string Name { get; set; }

        [Required]
        [Range(1950, 2025, ErrorMessage = "Release year must be between 1960 and 2025")]
        public int ReleaseYear { get; set; }

        [Required]
        public int GenreId { get; set; }

        public virtual GenreDTO Genre { get; set; }
    }
}
