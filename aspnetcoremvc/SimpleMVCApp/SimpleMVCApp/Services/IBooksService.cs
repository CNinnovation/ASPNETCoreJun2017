using System.Collections.Generic;
using SimpleMVCApp.Models;

namespace SimpleMVCApp.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetBooks();
    }
}