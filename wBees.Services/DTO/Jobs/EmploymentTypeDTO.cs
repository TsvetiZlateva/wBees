using System;
using System.Collections.Generic;
using wBees.Data.Models;

namespace wBees.Services.DTO.Jobs
{
    public class EmploymentTypeDTO
    {
        public EmploymentTypeDTO()
        {
            this.Jobs = new List<Job>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual List<Job> Jobs { get; set; }
    }
}
