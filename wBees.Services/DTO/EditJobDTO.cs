using System;
using System.Collections.Generic;
using System.Text;

namespace wBees.Services.DTO
{
    public class EditJobDTO
    {
        public string Position { get; set; }

        public string Location { get; set; }

      
        public string Description { get; set; }


        public decimal Salary { get; set; }

        public string[] JobKeywords { get; set; }


        public string Industry { get; set; }


        public string[] SubIndustry { get; set; }


        public string EmploymentType { get; set; }


        public string SeniorityLevel { get; set; }
    }
}
