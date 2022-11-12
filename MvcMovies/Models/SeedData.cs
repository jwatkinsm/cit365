using Microsoft.EntityFrameworkCore;
using MvcMovies.Data;

namespace MvcMovies.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMoviesContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 7.99M,
                        ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI4NzQ1OTMyNV5BMl5BanBnXkFtZTYwMTE1NzQ3._V1_FMjpg_UX1000_.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Inspirational Drama",
                        Rating = "PG",
                        Price = 8.99M,
                        ImageUrl = "https://www.movieflavor.com/images/7b/7b8cb946b4b2ffa0f003fdecf5120c56.jpeg"
                    },

                    new Movie
                    {
                        Title = "The Other side of Heaven 2",
                        ReleaseDate = DateTime.Parse("2019-6-28"),
                        Genre = "Inspirational Drama",
                        Rating = "PG-13",
                        Price = 9.99M,
                        ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjIyMDJkNzYtOTlhYy00ZGQzLWI0MjctMjA3MGFmZTc0ZmQ5XkEyXkFqcGdeQXVyMTk3NDI2Njc@._V1_.jpg"
                    },

                    new Movie
                    {
                        Title = "The Book of Mormon Movie",
                        ReleaseDate = DateTime.Parse("2003-9-12"),
                        Genre = "Scripture Based",
                        Rating = "PG",
                        Price = 3.99M,
                        ImageUrl = "https://m.media-amazon.com/images/M/MV5BMGIzNmY5MjQtOTRmNy00YzNkLTkyMTUtMzk1NGMwZTA3ODRhXkEyXkFqcGdeQXVyNjExODE1MDc@._V1_.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
