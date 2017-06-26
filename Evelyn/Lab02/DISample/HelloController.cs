using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    class HelloController
    {
        private readonly IHelloService _HelloService;

        public HelloController(IHelloService HelloService)
        {
            _HelloService = HelloService;
        }

        public string Greeting(string name) => _HelloService.Hello(name);

    }
}
