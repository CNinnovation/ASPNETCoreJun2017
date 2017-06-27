using System.Collections.Generic;
using Lab04.Models;

namespace Lab04.Repos
{
    public interface IBooksRepo
    {
        List<Book> GetBooks();
    }
}