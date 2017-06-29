using Lab06.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab06.DBContext
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public void Initialize()
        {
            this.Database.EnsureCreated();
        }
    }
}
