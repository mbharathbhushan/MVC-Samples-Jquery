using _09_Hyderlinks_In_MVC.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09_Hyderlinks_In_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            var employees = employeeContext.Employees;
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            var employee = employeeContext.Employees.FirstOrDefault(x => x.EmployeeId == id);
            return View(employee);
        }
    }
}