using APIService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIService.Services
{
    public class BooksService : IBooksService
    {
        private List<Book> _books = new List<Book>();
        public BooksService()
        {
            InitBooks();
        }

        private void InitBooks()
        {
            _books.AddRange(Enumerable.Range(0, 30).Select(x => new Book { BookId = x, Title = $"title {x}", Publisher = "sample pub" }));
        }

        public IEnumerable<Book> GetBooks() => _books;

        public Book GetBook(int id) => _books.SingleOrDefault(b => b.BookId == id);

        public Book AddBook(Book book)
        {
            book.BookId = _books.Max(b => b.BookId) + 1;
            _books.Add(book);
            return book;
        }
    }
}
