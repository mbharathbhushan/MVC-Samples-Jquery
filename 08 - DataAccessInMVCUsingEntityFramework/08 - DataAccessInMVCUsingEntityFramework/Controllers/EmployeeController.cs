﻿using _08___DataAccessInMVCUsingEntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08___DataAccessInMVCUsingEntityFramework.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            var employee = employeeContext.Employees.Single(x => x.EmployeeId == id);
            return View(employee);
        }
    }
}