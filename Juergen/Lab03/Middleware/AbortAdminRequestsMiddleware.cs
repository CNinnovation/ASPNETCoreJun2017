using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Lab03.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AbortAdminRequestsMiddleware
    {
        private readonly RequestDelegate _next;

        public AbortAdminRequestsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            if (httpContext.Request.Path.StartsWithSegments("/admin"))
            {
                httpContext.Response.StatusCode = 401;
                return;
            }
            else
            {
                 await _next(httpContext);
                return;
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AbortAdminRequestsMiddlewareExtensions
    {
        public static IApplicationBuilder UseAbortAdminRequestsMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AbortAdminRequestsMiddleware>();
        }
    }
}
