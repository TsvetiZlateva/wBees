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
            //this.applicantsCount = this.Applicants.Count();
        }

        public Guid Id { get; set; }

        public DateTime PublishedOn { get; set; }

        [Required]
        [MaxLength(50)]
        public string Position { get; set; }
     
        public Guid LocationId { get; set; }
       
        public virtual Location Location { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        public virtual ICollection<JobKeyword> JobKeywords { get; set; }

        public Guid IndustryId { get; set; }
      
        public virtual Industry Industry { get; set; }

        //public Guid SubIndustryId { get; set; }
        //
        //public SubIndustry SubIndustry { get; set; }

        [Required]
        public EmploymentType EmploymentType { get; set; }

        [Required]
        public SeniorityLevel SeniorityLevel { get; set; }

        //[Required]
        public virtual IdentityUser PublishedBy { get; set; }

        public virtual ICollection<IdentityUser> Applicants { get; set; }

        //private int? applicantsCount;
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int? ApplicantsCount
        //{
        //    get
        //    {
        //        return this.applicantsCount;
        //    }

        //    //private set
        //    //{

        //    //}
        //}
    }
}
