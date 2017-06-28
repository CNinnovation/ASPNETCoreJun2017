using Microsoft.AspNetCore.Mvc;
using SimpleMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVCApp.Controllers
{
    public class AnotherBooksController : Controller
    {
        public IActionResult Book()
        {
            return View(new Book { Title = "init", Publisher = "init" });
        }

        [HttpPost]
        public IActionResult Book(Book book)
        {
            return View();
        }
    }
}
