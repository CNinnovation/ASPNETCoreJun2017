using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Text.Encodings.Web;
using System.Net;
using Lab03.Services;
using Lab03.Middleware;

namespace Lab03
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISampleService, SampleService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAbortAdminRequestsMiddleware();

            app.UseStaticFiles();

            app.Map("/static", HandleStaticRoute);
            app.Map("/showQuery", HandleParamsRoute);
            app.MapWhen(context => {
                return context.Request.Path.Equals("/sitemap.xml");
            }, HandleXmlSitemap);
            app.Map("/form", HandleForm);
            app.Map("/sample", HandleSample);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

        private static void HandleStaticRoute(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("static route");
            });
        }

        private static void HandleSample(IApplicationBuilder app)
        {
            app.Run(async context =>
            { 
                var c = app.ApplicationServices.GetService<ISampleService>();

                await context.Response.WriteAsync(c.DoSomething());
            });
        }

        private static void HandleForm(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                StringBuilder response = new StringBuilder();

                if(context.Request.Method.Equals("GET"))
                {
                    response.Append(@"<form method='post' action='/form'>
                                        <input type='text' id='text1' name='text1' />
                                        <br />
                                        <button type='submit'>Submit</button>
                                        </form>");
                }
                else
                {
                    response.Append(WebUtility.HtmlEncode(context.Request.Form["text1"]));
                }
                
                await context.Response.WriteAsync(response.ToString());
            });
        }

        private static void HandleXmlSitemap(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                // TODO: dynamic sitemap generation
                await context.Response.WriteAsync("sitemap xml");
            });
        }

        private static void HandleParamsRoute(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var query = context.Request.Query;

                // TODO: provide nicely formatted response

                StringBuilder sb = new StringBuilder();

               foreach(var element in query)
                {
                    sb.Append(WebUtility.HtmlEncode(element.Key));
                    sb.Append(": ");
                    sb.Append(WebUtility.HtmlEncode(element.Value));
                    sb.Append("<br />");
                }
               
                 await context.Response.WriteAsync(sb.ToString());
            });
        }

    }
}
