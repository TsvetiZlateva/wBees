using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wBees.Models.Jobs
{
    public class JobsTableViewModel
    {
        public Guid Id { get; set; }

        public string PublishedOn { get; set; }

        public string Position { get; set; }

        public string Employer { get; set; }

        public string Type { get; set; }
    }
}
