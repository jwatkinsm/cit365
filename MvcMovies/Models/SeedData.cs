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
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "PG-13",
                        Price = 7.99M,
                        ImageUrl = "https://source.unsplash.com/random/?movie"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "PG-13",
                        Price = 8.99M,
                        ImageUrl = "https://source.unsplash.com/random/?movie"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "PG-13",
                        Price = 9.99M,
                        ImageUrl = "https://source.unsplash.com/random/?movie"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "PG-13",
                        Price = 3.99M,
                        ImageUrl = "https://source.unsplash.com/random/?movie"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
