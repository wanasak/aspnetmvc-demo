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
            return View();
        }
    }
}