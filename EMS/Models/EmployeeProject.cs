using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class EmployeeProject
    {
        public int EmployeeId { get; set; } // FK

        public virtual Employee Employee { get; set; } // Navigation Prop

        public int ProjectId { get; set; } // FK

        public virtual Project Project { get; set; } // Navigation Prop
    }
}