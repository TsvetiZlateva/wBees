using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace wBees.Models.Administration
{
    public class UsersTableViewModel
    {
        public UsersTableViewModel()
        {
            this.Roles = new List<string>();
        }

        public string Id { get; set; }

        [DisplayName("User Name")]
        public string UserName { get; set; }

        public string Email { get; set; }

        [DisplayName("Email Confirmed")]
        public bool EmailConfirmed { get; set; }

        public List<string> Roles { get; set; }
    }
}
