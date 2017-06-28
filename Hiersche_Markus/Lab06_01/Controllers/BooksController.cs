using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Lab06_01.Models;

namespace Lab06_01.Controllers
{
    public class BooksController : Controller
    {
        private readonly BooksContext _context;

        public BooksController(BooksContext context)
        {
            this._context = context;
        }

        // GET /Books/Index
        public IActionResult Index()
        {
            //_context.Add(new boo)+
            _context.Books.Add(new Book(1, "abc1", "Abc1"));
            _context.Books.Add(new Book(2, "abc2", "Abc2"));
            _context.Books.Add(new Book(3, "abc3", "Abc3"));
            _context.Books.Add(new Book(4, "abc4", "Abc4"));
            var LoBooks = from b in _context.Books
                          select b;

            
            //ViewBag.Books = LoBooks;
            return View(LoBooks);
        }
    }
}
