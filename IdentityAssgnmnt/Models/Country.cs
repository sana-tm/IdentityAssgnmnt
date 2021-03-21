using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityAssgnmnt.Areas.Identity.Data;

namespace IdentityAssgnmnt.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}
