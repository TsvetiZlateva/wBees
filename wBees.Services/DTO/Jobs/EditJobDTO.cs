using System;
using System.Collections.Generic;
using System.Text;
using wBees.Data.Models;

namespace wBees.Services.DTO.Jobs
{
    public class EditJobDTO
    {

        public EditJobDTO()
        {           
            this.Keywords = new List<string>();
            //this.UserJobs = new List<UserJobsDTO>();
        }

        public Guid Id { get; set; }

        public string Position { get; set; }

        public string PublishedOn { get; set; }

        public string Employer { get; set; }

        public Guid LocationId { get; set; }

        public string Location { get; set; }
      
        public string Description { get; set; }

        public int? Salary { get; set; }

        public List<string> Keywords { get; set; }

        public string Industry { get; set; }

        public string SubIndustry { get; set; }

        public string EmploymentType { get; set; }

        public string SeniorityLevel { get; set; }

        public bool Applied { get; set; }

        public bool Saved { get; set; }

        //public List<UserJobsDTO> UserJobs { get; set; }
    }
}
