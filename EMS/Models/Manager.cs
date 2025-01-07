using System;
using System.Collections.Generic;

namespace EMS.Models
{
    class Manager
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}