using loadingpanel.Data;
using loadingpanel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingpanel.Controllers
{
    public class DataTablesController : Controller
    {
        private readonly IEmailSenderRepository _repository;

        public DataTablesController(IEmailSenderRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Message"] = "Please see the information below for the email sent history.";

            return View();
        }

        [HttpGet]
        public JsonResult GetEmailData()
        {
            return Json(_repository.GetAllEmailItems());
        }
    }
}
