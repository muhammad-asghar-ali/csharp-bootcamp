using System;
using System.Collections.Generic;

namespace EMS.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}