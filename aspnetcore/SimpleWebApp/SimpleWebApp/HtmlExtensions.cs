﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp
{

        public static class HtmlExtensions
        {
            public static string Div(this string value) =>
                $"<div>{value}</div>";

            public static string Span(this string value) =>
                $"<span>{value}</span>";

            public static string Il(this string value, string url) =>
                $@"<il><a href=""{url}"">{value}</a></il>";
        }

}
