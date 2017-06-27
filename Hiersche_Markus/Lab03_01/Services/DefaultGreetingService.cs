using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab03_01.Services
{
    public class DefaultGreetingService : IGreetingService
    {
        public string Greet(string name) => $"Hello, {name}";
    }
}
