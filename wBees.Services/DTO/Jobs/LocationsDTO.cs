using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wBees.Data.Models;

namespace wBees.Services.DTO.Jobs
{
    public class LocationsDTO
    {
        public LocationsDTO()
        {
            this.Jobs = new List<Job>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual List<Job> Jobs { get; set; }
    }
}
