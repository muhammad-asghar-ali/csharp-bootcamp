using System;
using System.Collections.Generic;

namespace EMS.Models
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Salary { get; set; }

        // One to One relation.
        public EmployeeDetails EmployeeDetails { get; set; }

        public int ManagerId { get; set; } // FK

        public Manager Manager { get; set; } // Navigation Prop

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}