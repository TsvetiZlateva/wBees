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
    public class JobIndustriesViewModel
    {
        public EditJobViewModel Job { get; set; }

        public List<IndustryViewModel> Industries { get; set; }      
    }
}
