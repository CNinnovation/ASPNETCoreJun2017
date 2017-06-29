using Lab06.DBContext;
using Lab06.Models;
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookID == id);

            return View(book);
        }

        [HttpGet]
        public IActionResult Edit2(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookID == id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();

            return View("EditSuccess");
        }
    }
}


