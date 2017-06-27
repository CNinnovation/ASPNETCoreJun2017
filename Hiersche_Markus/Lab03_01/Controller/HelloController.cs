using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03_01.Services;

namespace Lab03_01.Controller
{
    public class HelloController
    {
        private readonly IGreetingService _greetingService;
        public HelloController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }
        public string Index(string name) => _greetingService.Greet(name);
    }
}
