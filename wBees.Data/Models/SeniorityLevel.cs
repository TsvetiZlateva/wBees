using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wBees.Data.Models
{
    public class SeniorityLevel
    {
        public SeniorityLevel()
        {
            this.Id = Guid.NewGuid();
            this.Jobs = new HashSet<Job>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
