using System;
using System.Collections.Generic;
using wBees.Data.Models;

namespace wBees.Services.DTO.Jobs
{
    public class SeniorityLevelDTO
    {
        public SeniorityLevelDTO()
        {
            this.Jobs = new List<Job>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual List<Job> Jobs { get; set; }
    }
}
