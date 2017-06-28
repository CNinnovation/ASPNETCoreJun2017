using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleMVCApp.Models;

namespace SimpleMVCApp.Services
{

    public interface IBooksService
    {
        IEnumerable<Book> GetBooks();

    }
}
