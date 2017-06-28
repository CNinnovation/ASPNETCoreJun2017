using Lab04.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04.Controllers
{
    public class RedirectController : Controller
    {
        public IActionResult RedirectSample()
        {
            return Redirect("http://thecodinglove.com");
        }


    }
}
