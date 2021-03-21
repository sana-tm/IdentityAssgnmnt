using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IdentityAssgnmnt.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityAssgnmnt.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Country Id")]
        public int CountryId { get; set; }
        [Display(Name = "City Id")]
        public int CityId { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
    }
}
