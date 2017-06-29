using NetStandardLib;
using OldFrameworkLib;
using System;

namespace CoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Demo();
            string s = d.Foo("HELLO from .NET Core");
            Console.WriteLine(s);

            var d2 = new OldDemo();
            string s2 = d2.Foo("Hello from .NET Core");
            Console.WriteLine(s2);
        }
    }
}
