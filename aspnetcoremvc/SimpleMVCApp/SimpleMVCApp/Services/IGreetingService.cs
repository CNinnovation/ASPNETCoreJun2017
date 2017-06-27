using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVCApp.Services
{
    public interface IGreetingService
    {
        string Greet(string name);
    }
}
