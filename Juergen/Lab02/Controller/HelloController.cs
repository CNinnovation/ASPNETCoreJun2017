using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    public class HelloController
    {
        private IHelloService _service;

        public HelloController(IHelloService service)
        {
            _service = service;
        }

        public string Greeting()
        {
           return _service.Hello();
        }
    }
}
