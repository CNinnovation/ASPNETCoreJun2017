using System;
using Microsoft.Extensions.Logging;

namespace LoggingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            InitLogging();

            Foo();
        }

        private static void Foo()
        {
            Logger.LogInformation($"{nameof(Foo)} started");
            Bar("one");
            Logger.LogInformation($"{nameof(Foo)} finished");
        }

        private static void Bar(string s)
        {
            Logger.LogError("Some error in Bar");
        }

        static void InitLogging()
        {
            var loggerFactory = new LoggerFactory().AddConsole().AddDebug();
            Logger = loggerFactory.CreateLogger<Program>();
        }

        public static ILogger Logger { get; private set; }
    }
}
