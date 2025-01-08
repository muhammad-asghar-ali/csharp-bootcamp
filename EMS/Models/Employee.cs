using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long Salary { get; set; }

        // One to One relation.
        public virtual EmployeeDetails EmployeeDetails { get; set; }

        public int ManagerId { get; set; } // FK

        public virtual Manager Manager { get; set; } // Navigation Prop

        // for lazy loading make it virtual 
        // lazy loading work on virtual navigation property.
        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}