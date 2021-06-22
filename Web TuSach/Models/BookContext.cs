using System;
using System.Data.Entity;

namespace TuSach.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("Tusach")
{
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }
        
    }
}