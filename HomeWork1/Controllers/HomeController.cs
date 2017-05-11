using HomeWork1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var List = new List<MoneyModels>();
            Random RN = new Random();//RN 亂數
            DateTime Date;
            for (var i = 1; i <= 200; i++)
            {
                //種類
                var MNumber = RN.Next(0, 2);//MNumber產生0或1的亂數
                string MCategory = "";
                MCategory = MNumber == 0 ? "支出" : "收入";
                //if (MNumber == 0) Category = "支出";
                //else Category = "收入";

                //日期
                DateTime start = new DateTime(1995, 1, 1);
                var range = (DateTime.Today - start).Days;
                Date = start.AddDays(RN.Next(range));
                //金額
                var RMoney = RN.Next(1, 99999999);
                List.Add(new MoneyModels
                {
                    Number = i,
                    Category = MCategory,
                    Date = Date,
                    Money=RMoney
                });
            }
            return View(List);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}