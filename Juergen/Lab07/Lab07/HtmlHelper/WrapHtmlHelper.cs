using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab07.HtmlHelper
{
    public static class WrapHtmlHelper
    {
        public static IHtmlContent Barcode(this IHtmlHelper htmlHelper, int number)
        {
            var cont = @"█║▌│ █│║▌ ║││█║▌ │║║█║ │║║█║-"+number;


                return new HtmlString(cont);
        }
         
    }
}
