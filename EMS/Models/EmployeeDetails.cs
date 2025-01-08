using System;
using System.Collections.Generic;

namespace EMS.Models
{
    public class EmployeeDetails
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}