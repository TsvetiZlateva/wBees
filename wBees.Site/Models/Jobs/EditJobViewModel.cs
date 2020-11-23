using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wBees.Models.Jobs
{
    public class EditJobViewModel
    {
        public Guid Id { get; set; }
        public string Position { get; set; }

        public string PublishedOn { get; set; }

        public string Employer { get; set; }

        public string Location { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
     
        public string Salary { get; set; }

        public List<string> Keywords { get; set; }

        public string Industry { get; set; }

        public string SubIndustry { get; set; }

        public string EmploymentType { get; set; }
    
        public string SeniorityLevel { get; set; }

        public IdentityUser PublishedBy { get; set; }
    }
}
