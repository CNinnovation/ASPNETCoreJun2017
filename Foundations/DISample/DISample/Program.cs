using Microsoft.Extensions.DependencyInjection;
using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();
           // UseDependencyInjection();
            UseDependencyInjectionWithContainer();
        }

        private static void UseDependencyInjection()
        {
            IHelloService helloService = new MyHelloService();
            var greetingController = new GreetingController(helloService);
            string result = greetingController.MyWebGreeting("Katharina");
            Console.WriteLine(result);
        }

        private static void UseDependencyInjectionWithContainer()
        {
            var greetingController = Container.GetService<GreetingController>();
            string result = greetingController.MyWebGreeting("Stephanie");
            Console.WriteLine(result);
        }

        public static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IHelloService, MyHelloService>();
            services.AddTransient<GreetingController>();
            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }
    }
}