using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace wBees.Data.Models
{
    public class Industry
    {
        public Industry()
        {
            this.Id = Guid.NewGuid();
            this.SubIndustries = new HashSet<SubIndustry>();
            this.Jobs = new HashSet<Job>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public virtual ICollection<SubIndustry> SubIndustries { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
