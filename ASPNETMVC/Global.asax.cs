using ASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPNETMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Database.SetInitializer<Models.EmployeeContext>(new CreateDatabaseIfNotExists<EmployeeContext>());
            Database.SetInitializer<Models.EmployeeContext>(new EmployeeDbInitializer());
        }
    }
}
