using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab07.TagHelper
{

    [HtmlTargetElement(Attributes = "rdmcolor")]
    public class MyTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            Random randonGen = new Random();

            string color = "#";

            for(int i=0;i<6; i++)
            {
                color += randonGen.Next(0, 9).ToString();
            }

            string styleValue = string.Empty;

            if (output.Attributes.ContainsName("style"))
            {
                styleValue = string.Format("{0} {1}", output.Attributes["class"].Value, $"color: {color};");
            }
            else
            {
                styleValue = $"color: {color};";
            }

            output.Attributes.SetAttribute("style", styleValue);
        }
    }
}
