using Microsoft.Extensions.Logging;
using System;

namespace Lab02c
{
    class Program
    {
        static void Main(string[] args)
        {
            InitLogging();

            Foo();

            Console.ReadKey();
        }

        private static void Foo()
        {
            Logger.LogInformation("Entering foo");
            Bar("one");
            Logger.LogInformation("Leaving foo");
        }

        private static void Bar(string v)
        {
            Logger.LogError("Error bar");
        }

        static void InitLogging()
        {
            var loggerFactory = new LoggerFactory().AddConsole().AddDebug();

            Logger = loggerFactory.CreateLogger<Program>();
        }

        public static ILogger Logger { get; set; }
    }
}
