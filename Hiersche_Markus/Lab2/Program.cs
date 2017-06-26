using Microsoft.Extensions.DependencyInjection;
using System;

namespace Lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            var services = RegisterHelloServices();

            HelloController c = services.GetService<HelloController>();

            Console.WriteLine(c.Greeting());
            Console.ReadKey();
        }

        public static IServiceProvider RegisterHelloServices()
        {
            ServiceCollection services = new ServiceCollection();

            return services
               .AddTransient<IHelloService, HelloService>()
               .AddSingleton<HelloController>()
               .BuildServiceProvider();
        }
    }
}
