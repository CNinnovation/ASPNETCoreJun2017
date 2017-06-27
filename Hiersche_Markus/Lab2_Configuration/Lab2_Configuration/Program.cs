using Microsoft.Extensions.Configuration;
using System;

namespace Lab2_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void ReadConfig()
        {
            string str = Configuration.GetSection("MyConfig")["a"];
            Console.WriteLine("Setting \"a\": " + str + "\n");

            MyTypedSetting setting = new MyTypedSetting();
            Configuration.GetSection("MyTypedSetting").Bind(setting);
            Console.WriteLine(setting.title + " " + setting.zahl.b);

            Console.ReadKey();
        }

        public static IConfigurationRoot Configuration { get; private set; }
    }
}
