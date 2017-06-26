using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    public class HelloService : IHelloService
    {
        public string Hello()
        {
            return "Hello";
        }
    }
}
