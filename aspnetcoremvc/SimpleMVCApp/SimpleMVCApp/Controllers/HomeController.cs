using Microsoft.AspNetCore.Mvc;
using SimpleMVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGreetingService _greetingService;
        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public string Index()
        {
            return "<h1>Hello, ASP.NET Core MVC</h1>";
        }

        public int Add(int x, int y) => x + y;

        public string ToUpper(string id) => id.ToUpper();

        public string Hello(string id) => _greetingService.Greet(id);

    }
}
