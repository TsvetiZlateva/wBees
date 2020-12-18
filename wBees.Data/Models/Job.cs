using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace wBees.Data.Models
{
    public class Job
    {
        public Job()
        {
            this.Id = Guid.NewGuid();
            this.JobKeywords = new HashSet<JobKeyword>();
            //this.Applicants = new HashSet<ApplicationUser>();
        }

        public Guid Id { get; set; }

        public DateTime PublishedOn { get; set; }

        //[Required]
        public virtual ApplicationUser PublishedBy { get; set; }

        [Required]
        [MaxLength(50)]
        public string Position { get; set; }

        [Required]
        [MaxLength(50)]
        public string Employer { get; set; }

        public Guid LocationId { get; set; }
       
        public virtual Location Location { get; set; }

        public int? Salary { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

       //public Guid IndustryId { get; set; }
       //
       //public virtual Industry Industry { get; set; }

        public Guid SubIndustryId { get; set; }

        public virtual SubIndustry SubIndustry { get; set; }

        public Guid EmploymentTypeId { get; set; }

        public virtual EmploymentType EmploymentType { get; set; }

        public Guid SeniorityLevelId { get; set; }

        public virtual SeniorityLevel SeniorityLevel { get; set; }

        public virtual ICollection<JobKeyword> JobKeywords { get; set; }

        //public virtual ICollection<ApplicationUser> Applicants { get; set; }

    }
}
