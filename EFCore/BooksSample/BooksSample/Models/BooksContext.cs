using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksSample.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext()
        {

        }

        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;database=BooksSample3;trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().Property(b => b.Publisher).HasMaxLength(25).IsRequired();

        }

        public DbSet<Book> Books { get; set; }
    }
}
