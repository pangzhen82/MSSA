using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_1Books_WPF_SQLite.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions <BookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
        private Book[] GetBooks()
        {
            return new Book[]
            {
                new Book {ID = 123450001, BookTitle = "C/C++ Programming", AuthorName = "Steve Jobs", Description = "Foundamental programming in C/C++", Quantity = 3},
                new Book {ID = 123450002, BookTitle = "Data Structure 101", AuthorName = "Jackie Chan", Description = "Array, List, Stack, Graphs", Quantity = 2},
                new Book {ID = 123450003, BookTitle = "Java Developer Guide", AuthorName = "Steph Curry", Description = "Programming foundamental in Java 8.0", Quantity = 4},
                new Book {ID = 123450004, BookTitle = "Advanced Algorithms", AuthorName = "Michael Jackson", Description = "Steps approach to advanced algorithms", Quantity = 7},
                new Book {ID = 123450005, BookTitle = "Python Automation", AuthorName = "Nathan James", Description = "Testing automation foundamental using python", Quantity = 5},
            };
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(GetBooks());
            base.OnModelCreating(modelBuilder);
        }
    }
}
