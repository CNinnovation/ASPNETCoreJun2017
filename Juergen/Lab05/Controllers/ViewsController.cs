using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
    }
}
