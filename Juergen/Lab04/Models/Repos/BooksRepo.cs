using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04.Models;

namespace Lab04.Repos
{
    public class BooksRepo : IBooksRepo
    {
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>()
            {
                new Book() { Id = 1, Title = "Holy Bible" },
                new Book() { Id = 2, Title = "Holy Bible V.2" }
            };

            return books;
        }
    }
}
