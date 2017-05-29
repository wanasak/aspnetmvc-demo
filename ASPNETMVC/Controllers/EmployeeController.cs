using ASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int departmentId)
        {
            EmployeeContext context = new EmployeeContext();
            List<Employee> employees = context.Employees.Where(e => e.DepartmentId == departmentId).ToList();
            return View(employees);
        }

        public ActionResult Details(int employeeId)
        {
            EmployeeContext context = new EmployeeContext();
            Employee employee = context.Employees.Include(e => e.Department).SingleOrDefault(e => e.EmployeeId == employeeId);
            return View(employee);
        }
    }
}