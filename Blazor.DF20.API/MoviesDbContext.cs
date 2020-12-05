using Microsoft.EntityFrameworkCore;
using Genre = Blazor.DF20.API.Models.Genre;
using Movie = Blazor.DF20.API.Models.Movie;

namespace Blazor.DF20.API
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 1, Name = "Action" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 2, Name = "Comedy" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 3, Name = "Movies for kids" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 4, Name = "Romance" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 5, Name = "Science Fiction" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 6, Name = "Thriller" });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 1,
               Name = "Captain America : The Winter Soldier",
               GenreId =1
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 2,
                Name = "Home Alone",
                GenreId = 3
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 3,
                Name = "Toy Story",
                GenreId = 3
            });
        }
    }
}
