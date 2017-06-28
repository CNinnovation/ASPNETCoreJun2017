using SimpleMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVCApp.Services
{
    public class BooksService : IBooksService
    {
        public IEnumerable<Book> GetBooks() =>
            Enumerable.Range(0, 10).Select(x => new Book { BookId = x, Title = $"Title {x}", Publisher = "Sample Pub" }).ToList();
    }
}
