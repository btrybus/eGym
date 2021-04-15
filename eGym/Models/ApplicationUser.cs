using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace eGym.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}