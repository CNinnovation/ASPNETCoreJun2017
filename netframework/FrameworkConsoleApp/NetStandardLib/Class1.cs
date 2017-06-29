using System;

namespace NetStandardLib
{
    public class Demo
    {
        public string Foo(string s)
        {
            Console.WriteLine($"NETStandard {s}");
            return s.ToLower();
        }
    }
}
