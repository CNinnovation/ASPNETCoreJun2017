using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class HelloService : IHelloService
    {
        public string Hello(String name) => $"Hello, {name}";
    }
}
