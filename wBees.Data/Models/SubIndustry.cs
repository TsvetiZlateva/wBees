using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace wBees.Data.Models
{
    public class SubIndustry
    {
        public SubIndustry()
        {
            this.Id = Guid.NewGuid();
            //this.Jobs = new HashSet<Job>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public Guid IndustryId { get; set; }

        public virtual Industry Industry { get; set; }

        //public virtual ICollection<Job> Jobs { get; set; }
    }
}