using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "wohoo";
        }

        public string Greeting1(string id)
        {
            return $"Hello, {id}";
        }
        public string Greeting2(string name)
        {
            return $"Hello, {name}";
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
