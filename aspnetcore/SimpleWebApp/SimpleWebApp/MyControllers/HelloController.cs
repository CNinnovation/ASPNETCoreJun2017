using SimpleWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.MyControllers
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
