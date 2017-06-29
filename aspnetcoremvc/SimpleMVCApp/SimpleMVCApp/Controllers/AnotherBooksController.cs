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
            if (!ModelState.IsValid)
            {
                // don't write it to DB
            }
            return View();
        }

        public IActionResult Book2()
        {
            return View(new Book { Title = "init", Publisher = "init" });
        }

        public IActionResult Book3()
        {
            return View(new Book { Title = "init", Publisher = "init" });
        }

        public string Sample() => "sample";
    }
}
