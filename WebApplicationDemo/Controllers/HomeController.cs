using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class HomeController: Controller
    {
        public ActionResult Index()
        {
            var homeModel = new HomeVm
            {
                Date = DateTime.Today,
                Title = "Hello"
            };
            return View(homeModel);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}