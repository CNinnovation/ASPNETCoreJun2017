using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MyHelloService : IHelloService
    {
        public string Hello(string name) => $"Hello, {name}";
        //public string Hello(string name)
        //{
        //    return String.Format("Hello, {0}", name);
        //}
    }
}
