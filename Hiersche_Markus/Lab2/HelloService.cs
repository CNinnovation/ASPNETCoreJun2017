using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class HelloService : IHelloService
    {
        public string Hello()
        {
            return "Hello";
        }
    }
}
