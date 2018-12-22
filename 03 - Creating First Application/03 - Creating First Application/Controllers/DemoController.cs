using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03___Creating_First_Application.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public string Index(int? id)
        {
            return "Id :" + (id.HasValue ? id.ToString() : "null");
        }
    }
}