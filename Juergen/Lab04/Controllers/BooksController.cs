using Lab04.Models;
using Lab04.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04.Controllers
{
    public class BooksController : Controller
    {
        private IBooksRepo _repo;

        public BooksController(IBooksRepo repo)
        {
            _repo = repo;
        }

        public string Index()
        {
            return "Better than amazon!";
        }

        public IActionResult GetBooks()
        {
            List<Book> books = _repo.GetBooks();

            return Json(books);
        }


    }
}
