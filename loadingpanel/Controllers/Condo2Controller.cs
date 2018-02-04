using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingpanel.Controllers
{
    public class MonthlyEmailItem
    {
        public int monthlyCount { get; set; }
        public string monthName { get; set; }
    }

    public class Condo2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult NewChart()
        {
            List<MonthlyEmailItem> MonthlyEmailItemList = new List<MonthlyEmailItem>()
            {
               new MonthlyEmailItem {monthlyCount = 100, monthName="January"},
               new MonthlyEmailItem {monthlyCount = 102, monthName="February"},
               new MonthlyEmailItem {monthlyCount = 120, monthName="April"},
               new MonthlyEmailItem {monthlyCount = 130, monthName="March"},
               new MonthlyEmailItem {monthlyCount = 140, monthName="May"},
               new MonthlyEmailItem {monthlyCount = 150, monthName="June"},
               new MonthlyEmailItem {monthlyCount = 160, monthName="July"},
               new MonthlyEmailItem {monthlyCount = 170, monthName="August"},
               new MonthlyEmailItem {monthlyCount = 180, monthName="September"},
               new MonthlyEmailItem {monthlyCount = 190, monthName="October"},
               new MonthlyEmailItem {monthlyCount = 200, monthName="November"},
               new MonthlyEmailItem {monthlyCount = 400, monthName="December"}
            };

            List<object> iData = new List<object>();
            List<object> name = new List<object>();
            List<object> count = new List<object>();

            foreach(MonthlyEmailItem item in MonthlyEmailItemList)
            {
                name.Add(item.monthName);
                count.Add(item.monthlyCount);
            }

            iData.Add(name);
            iData.Add(count);

            //Source data returned as JSON
            return Json(iData);
        }
    }
}