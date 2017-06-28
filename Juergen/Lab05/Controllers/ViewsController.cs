using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab05.Models;

namespace Lab05.Controllers
{
    public class ViewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UsingLayout()
        {
            ViewBag.Navigation = "TopNav2";
            return View();
        }

        public IActionResult PassingData1()
        {
            ViewBag.Content = "PassingData1 Content";
            return View();
        }

        public IActionResult PassingData2()
        {
            // Too Lazy to create a real Model
            return View((object)"PassingData2 Content");
        }

        public IActionResult TopBooks(int id)
        {
            var books = Enumerable.Range(id * 10, 10).Select(r => new Book() { Title = $"Title {r}" }).ToList();
            return PartialView(books);
        }

        public IActionResult TopBooksList()
        {
            return View();
        }
    }
}
