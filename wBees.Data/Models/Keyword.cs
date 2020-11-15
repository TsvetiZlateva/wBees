using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace wBees.Data.Models
{
    public class Keyword
    {
        public Keyword()
        {
            this.Id = Guid.NewGuid();
            this.JobKeywords = new HashSet<JobKeyword>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public virtual ICollection<JobKeyword> JobKeywords { get; set; }
    }
}
