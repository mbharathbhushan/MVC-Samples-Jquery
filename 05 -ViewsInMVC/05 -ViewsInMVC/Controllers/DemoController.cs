using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05__ViewsInMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>() { "India", "US", "UK", "Canada" };
            ViewData["States"] = new List<string>() { "Telangana","Andhra Pradhesh","Kerala" };
            ViewBag.Title = "Demo - Index";
            return View();
        }
    }
}