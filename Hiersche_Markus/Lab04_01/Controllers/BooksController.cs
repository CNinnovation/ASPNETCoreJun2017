using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04_01.Controllers
{
    public class BooksController : Controller
    {
        // GET /Books/Index
        public IActionResult Index()
        {
            List<Models.Books> ListOfBooks = new List<Models.Books>();
            ListOfBooks.Add(new Models.Books(733, "Harry Potter I", "J. K. Rolling"));
            ListOfBooks.Add(new Models.Books(1480, "Professional C# 6 and .Net Core 1.0", "Christian Nagel"));
            ListOfBooks.Add(new Models.Books(123, "DemoTitel", "DemoAuthor"));
            return View(ListOfBooks);
        }

        // GET /Books/Json
        public IActionResult Json()
        {
            List<Models.Books> ListOfBooks = new List<Models.Books>();
            ListOfBooks.Add(new Models.Books(733, "Harry Potter I", "J. K. Rolling"));
            ListOfBooks.Add(new Models.Books(1480, "Professional C# 6 and .Net Core 1.0", "Christian Nagel"));
            ListOfBooks.Add(new Models.Books(123, "DemoTitel", "DemoAuthor"));
            return Json(ListOfBooks);
        }
    }
}
