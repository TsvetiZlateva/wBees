using System;
using System.Collections.Generic;
using System.Text;
using wBees.Data.Models;

namespace wBees.Services.DTO
{
    public class IndustryDTO
    {
        public Guid Id { get; set; }            

        public string Name { get; set; }

        public virtual List<SubIndustry> SubIndustries { get; set; }
        public virtual List<Job> Jobs { get; set; }
    }
}
