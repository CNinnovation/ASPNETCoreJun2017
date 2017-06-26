using Microsoft.Extensions.DependencyInjection;
using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //UseDependencyInjection();
            RegisterServices();
            UseDependencyInjectionWithContainer();
        }

        private static void UseDependencyInjection()
        {
            IHelloService hello = new HelloService();

            var greetingController = new HelloController(hello);

            string result = greetingController.Greeting("Tobi");

            Console.WriteLine(result);
        }

        private static void UseDependencyInjectionWithContainer()
        {
            var greetingController = Container.GetService<HelloController>();

            string result = greetingController.Greeting("David");

            Console.WriteLine(result);
        }

        public static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IHelloService, HelloService>();
            services.AddTransient<HelloController>();
            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }
    }
}
