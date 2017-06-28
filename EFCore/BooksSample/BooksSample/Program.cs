using BooksSample.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;

namespace BooksSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreateAndFillTheDatabase();
            RegisterServices();
            CreateAndFillTheDatabaseUsingDI();
        }

        private static void CreateAndFillTheDatabaseUsingDI()
        {
            var context = Container.GetService<BooksContext>();
            bool created = context.Database.EnsureCreated();
            Console.WriteLine($"created: {created}");
            context.Books.Add(new Book { Title = "Professional C# 7", Publisher = "Wrox Press" });
            int changed = context.SaveChanges();
        }

        //private static void CreateAndFillTheDatabase()
        //{
        //    using (var context = new BooksContext())
        //    {
        //        bool created = context.Database.EnsureCreated();
        //        Console.WriteLine($"created: {created}");
        //        context.Books.Add(new Book { Title = "Professional C# 6", Publisher = "Wrox Press" });
        //        int changed = context.SaveChanges();
        //    }
        //}

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<BooksContext>(options =>
            {
                options.UseSqlServer(@"server=(localdb)\mssqllocaldb;database=BooksSample2;trusted_connection=true");
            });
            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }
    }
}
