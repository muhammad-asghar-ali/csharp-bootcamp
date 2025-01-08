using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}