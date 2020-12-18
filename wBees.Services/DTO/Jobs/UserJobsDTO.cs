using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wBees.Services.DTO.Jobs
{
    public class UserJobsDTO
    {
        public string UserId { get; set; }
       // public virtual ApplicationUser User { get; set; }

        public Guid JobId { get; set; }

       // public virtual Job Job { get; set; }

        public bool Saved { get; set; }

        public bool Applied { get; set; }
    }
}
