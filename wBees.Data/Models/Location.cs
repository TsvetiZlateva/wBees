using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace wBees.Data.Models
{
    public class Location
    {
        public Location()
        {
            this.Id = Guid.NewGuid();
            this.Jobs = new HashSet<Job>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
