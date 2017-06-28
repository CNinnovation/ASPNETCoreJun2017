using Microsoft.AspNetCore.Mvc;
using SimpleMVCApp.Models;
using SimpleMVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVCApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;
        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        public IActionResult Books()
        {
            IEnumerable<Book> books = _booksService.GetBooks();
            return Json(books);
        }

        public IActionResult SimpleView()
        {
            ViewData["Book1"] = new Book { BookId = 42, Title = "Professional C# 7.2" };
            ViewBag.Book2 = new Book { BookId = 42, Title = "Professional C# 8" };
            return View();
        }

        public IActionResult SimpleView2()
        {
            ViewData["Book1"] = new Book { BookId = 42, Title = "Professional C# 7.2" };
            ViewBag.Book2 = new Book { BookId = 42, Title = "Professional C# 8" };
            return View("AnotherView");
        }

        public IActionResult BooksList()
        {
            IEnumerable<Book> books = _booksService.GetBooks();
            ViewBag.Books = books;
            return View();
        }

        public IActionResult BooksList2()
        {
            IEnumerable<Book> books = _booksService.GetBooks();
            return View(books);
        }

        public IActionResult MyPartialView()
        {
            return PartialView();
        }

        public IActionResult MyClientView()
        {
            return View();
        }

        public IActionResult ViewComponent1()
        {
            return ViewComponent("BooksList", new { publisher = "Wrox Press" });
        }

        public IActionResult ViewComponent2()
        {
            return View();
        }
    }
}
