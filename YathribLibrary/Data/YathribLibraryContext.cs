using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace YathribLibrary.Models
{
    public class YathribLibraryContext : DbContext
    {
        public YathribLibraryContext (DbContextOptions<YathribLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<YathribLibrary.Models.Book> Book { get; set; }
    }
}
