using System.Collections.Generic;
using APIService.Models;

namespace APIService.Services
{
    public interface IBooksService
    {
        Book GetBook(int id);
        IEnumerable<Book> GetBooks();
        Book AddBook(Book book);
    }
}