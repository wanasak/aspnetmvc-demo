using ASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            EmployeeContext context = new EmployeeContext();
            IEnumerable<Department> departments = context.Departments.ToList();
            return View(departments);
        }
    }
}