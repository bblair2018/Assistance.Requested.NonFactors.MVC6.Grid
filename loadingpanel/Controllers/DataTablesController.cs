using loadingpanel.Data;
using loadingpanel.ViewModels;
using Microsoft.AspNetCore.Mvc;
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

            List<SendEmailViewModel> sendList = new List<SendEmailViewModel>();
            SendEmailViewModel SendEmailViewModelItem;

            var results = _repository.GetAllEmailItems();

            foreach (var resultItem in results)
            {
                SendEmailViewModelItem = new SendEmailViewModel()
                {
                    Email = resultItem.toEmailAddress,
                    Name = resultItem.fromName,
                    Message = resultItem.toMessage,
                    Subject = resultItem.toSubject,
                    TimeStampSent = resultItem.emailSentTimeStamp
                };
                sendList.Add(SendEmailViewModelItem);
            }

            return View(sendList);
        }
    }
}
