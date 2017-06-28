using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04_01.Controllers
{
    public class HomeController : Controller
    {
        // GET /Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET /Home/PassingData1
        public IActionResult PassingData1()
        {

            return View();
        }
    }
}
