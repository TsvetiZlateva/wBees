using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wBees.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.UserJobs = new HashSet<UserJobs>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }

        public int? WantedSalary { get; set; }

        [MaxLength(2000)]
        public string Interests { get; set; }

        public virtual ICollection<UserJobs> UserJobs { get; set; }
    }
}
