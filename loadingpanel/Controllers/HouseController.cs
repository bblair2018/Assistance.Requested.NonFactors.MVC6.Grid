using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace loadingpanel.Controllers
{
    public class HouseController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index(string message)
        {
            Thread.Sleep(3000);
            //ViewData["Message"] = "Your *REAL* email has been sent!!!!!!";
            ViewData["Message"] = message;
            return View();
        }
    }
}
