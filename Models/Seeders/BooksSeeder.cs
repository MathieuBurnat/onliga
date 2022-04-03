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
                        Description = "Dans One Piece, nous suivons l'histoire d'un jeune pirate, Monkey D. Luffy, dont le rêve est de prendre la mer pour devenir le Seigneur des pirates. Lui et son équipage de pirates voguent sur les océans à la recherche du trésor le plus convoité de l'histoire de la piraterie : le One Piece.",
                        ReleaseDate = DateTime.Parse("1989-1-11"),
                        Genre = "Romantic Comedy",
                    },

                    new Book
                    {
                        Title = "Good night punpun",
                        Description = "",
                        ReleaseDate = DateTime.Parse("2003-3-13"),
                        Genre = "Comedy",
                    },

                    new Book
                    {
                        Title = "Death Note",
                        Description = "Based on the famous Japanese manga written by Tsugumi Ohba and Takeshi Obata, Death Note follows a high school student who comes across a supernatural notebook, realizing it holds within it a great power; if the owner inscribes someone's name into it while picturing their face, he or she will die.",
                        ReleaseDate = DateTime.Parse("2003-2-23"),
                        Genre = "Action",
                    },

                    new Book
                    {
                        Title = "Full metal alchemist",
                        Description = "Fullmetal Alchemist (鋼の錬金術師, Hagane no Renkinjutsushi, littéralement « L'Alchimiste d'acier », souvent abrégé en Hagaren (ハガレン) ou en FMA), est un manga d'Hiromu Arakawa. Il a été prépublié entre 2001 et 2010 dans le magazine mensuel Shōnen Gangan de la société Square Enix et a été compilé en 27 volumes reliés",
                        ReleaseDate = DateTime.Parse("2001-4-15"),
                        Genre = "Action",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}