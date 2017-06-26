using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class GreetingController
    {
        private readonly IHelloService _helloService;
        public GreetingController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        public string MyWebGreeting(string name) => _helloService.Hello(name);
    }
}
