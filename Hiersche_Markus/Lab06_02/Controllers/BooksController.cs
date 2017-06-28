using Lab06_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab06_02.Controllers
{
    public class BooksController
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
            _context.Books.Add(new Book("abc1", "Abc1"));
            _context.Books.Add(new Book("abc2", "Abc2"));
            _context.Books.Add(new Book("abc3", "Abc3"));
            _context.Books.Add(new Book("abc4", "Abc4"));
            var LoBooks = from b in _context.Books
                          select b;


            //ViewBag.Books = LoBooks;
            return View(LoBooks);
        }
    }
}
