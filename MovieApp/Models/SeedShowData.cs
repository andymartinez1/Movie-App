using Microsoft.EntityFrameworkCore;
using MovieApp.Data;

namespace MovieApp.Models;

public static class SeedShowData
{
    public static void InitializeShows(IServiceProvider serviceProvider)
    {
        using (
            var context = new TelevisionShowContext(
                serviceProvider.GetRequiredService<DbContextOptions<TelevisionShowContext>>()
            )
        )
        {
            // Look for any shows
            if (context.Show.Any())
                return; // DB has been seeded

            context.Show.AddRange(
                new TelevisionShow
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M,
                },
                new TelevisionShow
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M,
                }
            );
        }
    }
}
