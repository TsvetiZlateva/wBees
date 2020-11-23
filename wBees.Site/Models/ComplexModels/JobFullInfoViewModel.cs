using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wBees.Models.Industries;
using wBees.Models.Jobs;
using wBees.Services.DTO;
using wBees.Services.IndustriesBusiness;

namespace wBees.Models.ComplexModels
{
    public class JobFullInfoViewModel
    {
        public JobFullInfoViewModel()
        {
            this.Industries = new List<IndustryViewModel>();
            this.Locations = new List<SelectListItem>();
            this.EmploymentTypes = new List<EmploymentTypeViewModel>();
            this.SeniorityLevels = new List<SeniorityLevelViewModel>();
        }

        public EditJobViewModel Job { get; set; }

        public List<IndustryViewModel> Industries { get; set; }

        public List<SelectListItem> Locations { get; set; }

        public List<EmploymentTypeViewModel> EmploymentTypes { get; set; }

        public List<SeniorityLevelViewModel> SeniorityLevels { get; set; }
    }
}
