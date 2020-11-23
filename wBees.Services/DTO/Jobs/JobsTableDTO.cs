using System;
using System.Collections.Generic;
using System.Text;

namespace wBees.Services.DTO.Jobs
{
    public class JobsTableDTO
    {
        public Guid Id { get; set; }

        public string PublishedOn { get; set; }

        public string Position { get; set; }

        public string Employer { get; set; }

        public string Type { get; set; }
    }
}
