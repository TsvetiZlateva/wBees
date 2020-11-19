using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using wBees.Models.Jobs;

namespace wBees.Models.Industries
{
    public class IndustryViewModel
    {
        public IndustryViewModel()
        {
            this.SubIndustries = new List<SubIndustryViewModel>();
            this.Jobs = new List<EditJobViewModel>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual List<SubIndustryViewModel> SubIndustries { get; set; }
        public virtual List<EditJobViewModel> Jobs { get; set; }
    }
}
