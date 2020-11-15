using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using wBees.Data.Enums;

namespace wBees.Data.Models
{
    public class Job
    {
        public Job()
        {
            this.Id = Guid.NewGuid();
            this.JobKeywords = new HashSet<JobKeyword>();
            this.Applicants = new HashSet<IdentityUser>();
        }

        public Guid Id { get; set; }

        public DateTime PublishedOn { get; set; }

        [Required]
        [MaxLength(30)]
        public string Position { get; set; }
     
        public Guid LocationId { get; set; }
       
        public Location Location { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        public virtual ICollection<JobKeyword> JobKeywords { get; set; }

        public Guid IndustryId { get; set; }
      
        public Industry Industry { get; set; }

        //public Guid SubIndustryId { get; set; }
     
        //public SubIndustry SubIndustry { get; set; }

        [Required]
        public EmploymentType EmploymentType { get; set; }

        [Required]
        public SeniorityLevel SeniorityLevel { get; set; }

        [Required]
        public IdentityUser PublishedBy { get; set; }

        public virtual ICollection<IdentityUser> Applicants { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int ApplicantsCount
        {
            get
            {
                return this.Applicants.Count();
            }

            private set
            {

            }
        }
    }
}
