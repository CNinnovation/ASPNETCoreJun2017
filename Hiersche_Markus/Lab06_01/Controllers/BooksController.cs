using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Lab06_01.Models;

namespace Lab06_01.Controllers
{
    public class BooksController : Controller
    {
        // GET /Books/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
