using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Services
{
    public class DefaultGreetingService : IGreetingService
    {
        public string Greet(string name) => $"Hello, {name}";
    }
}
