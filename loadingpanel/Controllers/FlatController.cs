using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace loadingpanel.Controllers
{
    public class FlatController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "This is a test!";
            return View();
        }

        [HttpGet]
        public IActionResult Dog(string message)
        {
            //Try viewbag
            Thread.Sleep(3000);
            ViewData["Message"] = message;
            return PartialView("_Message");
        }
    }
}
