using NetStandardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Demo();
            string s = d.Foo("HELLO from the old framework");
            Console.WriteLine(s);
        }
    }
}
