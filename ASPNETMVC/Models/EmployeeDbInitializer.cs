using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNETMVC.Models
{
    public class EmployeeDbInitializer : DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var departments = new List<Department>()
            {
                new Department { Name = "IT" },
                new Department { Name = "HR" },
                new Department { Name = "Engineer" }
            };
            context.Departments.AddRange(departments);
            context.SaveChanges();

            var employees = new List<Employee>()
            {
                new Employee { Name = "Peter", Gender = "Male", City = "London", DepartmentId = 3 },
                new Employee { Name = "Rick", Gender = "Male", City = "Paris", DepartmentId = 2 },
                new Employee { Name = "Yuliya", Gender = "Female", City = "New York", DepartmentId = 1 },
                new Employee { Name = "Jake", Gender = "Male", City = "Chiang Mai", DepartmentId = 1 },
            };
            context.Employees.AddRange(employees);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}