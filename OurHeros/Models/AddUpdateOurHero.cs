using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurHeros.Model
{
    public class AddUpdateOurHero
    {
        public required string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}