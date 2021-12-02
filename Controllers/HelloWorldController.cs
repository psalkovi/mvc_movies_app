using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MS_MVC_tutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int NumTimes)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = NumTimes;

            return View();
        }
    }
}
