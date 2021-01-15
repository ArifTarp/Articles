using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Articles.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            //TO DO api will be connect
            return RedirectToAction("Index","Home");
        }
    }
}
