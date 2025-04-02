using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using W25Week12IntroToWebApi.Models;

namespace W25Week12IntroToWebApi.Data
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;

        // data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "HTML", Price = 10 },
                new Book { BookId = 2, Title = "C#", Price = 20 },
                new Book { BookId = 3, Title = "JavaScript", Price = 30 }
            );
        }
    }
}
