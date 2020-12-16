using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wBees.Services.DTO.Administration
{
    public class UsersTableDTO
    {
        public UsersTableDTO()
        {
            this.Roles = new List<string>();
        }

        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public List<string> Roles { get; set; }
    }
}
