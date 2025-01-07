using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Models
{
    class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}