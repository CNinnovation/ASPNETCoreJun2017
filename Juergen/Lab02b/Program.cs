using Lab02.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Lab02
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }


        static void Main(string[] args)
        {
            SetupConfiguration(args);
            var services = RegisterServices();

            Console.WriteLine("direct: " + Configuration.GetConnectionString("Default"));

            ConfigReaderController cr = services.GetService<ConfigReaderController>();
            Console.WriteLine("injected: " + cr.GetConnString());

            cr.GetCachingInfos();

            Console.ReadKey();
        }

        public static void SetupConfiguration(string[] args)
        {
            var builder = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                  .AddCommandLine(args)
                  .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public static IServiceProvider RegisterServices()
        {
            ServiceCollection services = new ServiceCollection();

            return services
               .AddSingleton<ConfigReaderController>()
               .AddOptions()
               .Configure<ConfigSettings>(Configuration.GetSection("Settings"))
               .Configure<Caching>(Configuration.GetSection("Caching"))
               .BuildServiceProvider();
        }
    }
}
