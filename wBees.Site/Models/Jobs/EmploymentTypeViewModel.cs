using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wBees.Models.Jobs
{
    public class EmploymentTypeViewModel
    {
        public EmploymentTypeViewModel()
        {
            this.Id = Guid.NewGuid();
            this.Jobs = new List<EditJobViewModel>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public virtual List<EditJobViewModel> Jobs { get; set; }

    }
}
