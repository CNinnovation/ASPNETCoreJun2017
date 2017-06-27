using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.IO;
using SimpleWebApp.Services;
using SimpleWebApp.MyControllers;
using SimpleWebApp.Middleware;

namespace SimpleWebApp
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
              .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreetingService, DefaultGreetingService>();
            services.AddTransient<HelloController>();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
                options.IdleTimeout = TimeSpan.FromMinutes(2));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();        // add middleware for static files
            app.UseSession();
           // app.UseMyCustomMiddleware();


            app.Map("/mycontroller", app1 =>
            {
                app1.Run(async context =>
                {
                    string name = context.Request.Query["name"];
                    HelloController controller = app1.ApplicationServices.GetService<HelloController>();
                    string result = controller.Index(name);
                    await context.Response.WriteAsync(result);  // TODO: encoding!!
                });
            });

            app.Map("/session", sessionApp =>
            {
                sessionApp.Run(async context =>
                {
                    await SessionSample.SessionAsync(context);
                });
            });

            app.Map("/requestsample", app1 =>
            {
                app1.Run(async (context) =>
                {
                    string result = string.Empty;
                    switch (context.Request.Path.Value.ToLower())
                    {
                        case "/header":
                            result = RequestAndResponseSample.GetHeaderInformation(context.Request);
                            break;
                        case "/add":
                            result = RequestAndResponseSample.QueryString(context.Request);
                            break;
                        case "/content":
                            result = RequestAndResponseSample.Content(context.Request);
                            break;
                        case "/encoded":
                            result = RequestAndResponseSample.ContentEncoded(context.Request);
                            break;
                        case "/form":
                            result = RequestAndResponseSample.GetForm(context.Request);
                            break;
                        case "/writecookie":
                            result = RequestAndResponseSample.WriteCookie(context.Response);
                            break;
                        case "/readcookie":
                            result = RequestAndResponseSample.ReadCookie(context.Request);
                            break;
                        case "/json":
                            result = RequestAndResponseSample.GetJson(context.Response);
                            break;
                        default:
                            result = RequestAndResponseSample.GetRequestInformation(context.Request);
                            break;
                    }
                    await context.Response.WriteAsync(result);
                });
            });
            
            app.Run(async (context) =>
            {
                HttpRequest request = context.Request;

                await context.Response.WriteAsync("<h1>Hello World!</h1>");
            });
        }
    }
}
