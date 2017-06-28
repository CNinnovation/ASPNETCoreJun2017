using Lab06.DBContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab06.Controllers
{
    public class HomeController : Controller
    {
        private BooksContext _context;

        public HomeController(BooksContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Books.ToList();
            return View(result);
        }

        public IActionResult Add()
        {
            _context.Books.Add(new Models.Book { Title = "Dummy", Publisher = "Publisher" });
            _context.SaveChanges();

            return View(_context.Books.Count());
        }
    }
}


