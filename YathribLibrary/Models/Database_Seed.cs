using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace YathribLibrary.Models
{
    public class Database_Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new YathribLibraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<YathribLibraryContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Relentless: 12 Rounds to Success",
                        YearOfRelease = DateTime.Parse("29-10-2020"),
                        Genre = "Sports",
                        ISBN = "EH-748-4783",
                        Author = "Eddie Hearn",
                        Rating = "4/5"
                    },

                    new Book
                    {
                        Title = "Harry Potter and the Goblet of Fire",
                        YearOfRelease = DateTime.Parse("01-08-2014"),
                        Genre = "Fiction",
                        ISBN = "JK-743-4732",
                        Author = "J.K.ROWLING", 
                        Rating = "5/5"

                    },

                    new Book
                    {
                        Title = "Diary of a Wimpy Kid: The Deep End ",
                        YearOfRelease = DateTime.Parse("27-09-2020"),
                        Genre = "Children's Humour",
                        ISBN = "DW-574-9783",
                        Author = "Jeff Kinney",
                        Rating = "5/5"

                    },

                     new Book
                     {
                         Title = "A Promised Land ",
                         YearOfRelease = DateTime.Parse("17-10-2020"),
                         Genre = "Politics",
                         ISBN = "BO-954-Ab23",
                         Author = "Barack Obama",
                         Rating = "5/5"

                     },

                       new Book
                       {
                           Title = "The Midnight Library ",
                           YearOfRelease = DateTime.Parse("18-02-2021"),
                           Genre = "Fiction",
                           ISBN = "TM-954-Tb01",
                           Author = "Matt Haig",
                           Rating = "4.5/5"

                       },

                          new Book
                          {
                              Title = "Secret Weapon (Alex Rider)",
                              YearOfRelease = DateTime.Parse("03-09-2020"),
                              Genre = "Mystery",
                              ISBN = "SW-954-Tb01",
                              Author = "Anthony Horowitz",
                              Rating = "4.5/5"

                          }
                );
                context.SaveChanges();
            }
        }
    }
}
    
