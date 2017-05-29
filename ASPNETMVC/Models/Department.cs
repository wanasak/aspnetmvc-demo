using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETMVC.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Department()
        {
            Employees = new List<Employee>();
        }
    }
}