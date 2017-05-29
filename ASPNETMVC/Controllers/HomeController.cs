using ASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id, string name)
        {
            ViewBag.Message = $"Your id is {id} and name is {Request.QueryString["name"]}";
            ViewBag.Cars = new List<string>() { "Toyota", "Honda", "BMW" };
            ViewData["Numbers"] = new List<int>() { 1, 2, 3 };
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                Name = "Smudger",
                Gender = "Male",
                City = "Chiang Mai"
            };
            return View(employee);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext context = new EmployeeContext();
            Employee employee = context.Employees.Find(id);
            return View(employee);
        }
    }
}