using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class MyHelloService : IHelloService
    {
        public string Hello(string name) => $"Hello, {name}";
    }
}
