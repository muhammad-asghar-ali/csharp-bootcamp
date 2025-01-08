using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    [Table("Managers")]
    public class Manager
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}