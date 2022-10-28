using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Contact"); //will not produce "Contact" in URL but will still redirect to "contact" page. Returns the .cshtml file

            //return RedirectToAction("Contact"); // will redirect to "Contact" page with "Contact" in url. Hits the controller method as defined below

            ////////
            
            //Random randomNumber = new Random(10);
            //var num = randomNumber.Next();
            
            //if (num > 20_000)
            //{
            //    return View("About");
            //}

            ////////

            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\dell\TextFilesForAssignments\MVCTutorialText.txt", text);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid page"); // throws invalid page

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}