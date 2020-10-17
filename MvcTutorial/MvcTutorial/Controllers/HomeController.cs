using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Braydon";
            user.LastName = "Burrows";
            user.Age = 22;
            return View(user);
            //Random rnd = new Random();
            //int num = rnd.Next();

            //if(num > 20000)
            //{
            //    return View("About");
            //}

            //ViewBag.RandomNumber = num;
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\burro\Logs\log2.txt", text);
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