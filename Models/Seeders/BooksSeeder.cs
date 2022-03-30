using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using onliga.Models;
using System;
using System.Linq;
using onliga.Data;

namespace onliga.Seeders
{
    public static class BooksSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any Books.
                if (context.Books.Any())
                {
                    return;   // DB has been seeded
                }

                context.Books.AddRange(
                    new Book
                    {
                        Title = "one piece",
                        ReleaseDate = DateTime.Parse("1989-1-11"),
                        Genre = "Romantic Comedy",
                    },

                    new Book
                    {
                        Title = "Good night punpun",
                        ReleaseDate = DateTime.Parse("2003-3-13"),
                        Genre = "Comedy",
                    },

                    new Book
                    {
                        Title = "Death Note",
                        ReleaseDate = DateTime.Parse("2003-2-23"),
                        Genre = "Action",
                    },

                    new Book
                    {
                        Title = "Full metal alchemist",
                        ReleaseDate = DateTime.Parse("2001-4-15"),
                        Genre = "Action",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}