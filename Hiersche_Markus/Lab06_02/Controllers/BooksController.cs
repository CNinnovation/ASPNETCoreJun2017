using Lab06_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;

namespace Lab06_02.Controllers
{
    public class BooksController : Controller
    {
        /*private readonly BooksContext _context;

        public BooksController(BooksContext context)
        {
            this._context = context;
        }*/

        ListOfBooks lob = new ListOfBooks();

        //GET /Books/Index
        public IActionResult Index()
        {
            /*
            _context.Books.Add(new Book("abc1", "Abc1"));
            _context.Books.Add(new Book("abc2", "Abc2"));
            _context.Books.Add(new Book("abc3", "Abc3"));
            _context.Books.Add(new Book("abc4", "Abc4"));*/

            string tmp = "abc" + lob.Anz;
            lob.ListOfBooksAddBook(new Book(tmp.ToLower(), tmp.ToUpper()));
            return View(lob);
        }


        // GET /Books/Index
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
