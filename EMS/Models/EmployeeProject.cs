using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    [Table("EmployeeProjects")]
    public class EmployeeProject
    {
        [Key]
        public int EmployeeId { get; set; } // FK

        public virtual Employee Employee { get; set; } // Navigation Prop

        public int ProjectId { get; set; } // FK

        public virtual Project Project { get; set; } // Navigation Prop
    }
}