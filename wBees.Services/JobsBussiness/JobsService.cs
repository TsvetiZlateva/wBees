using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wBees.Data;
using wBees.Services.DTO;

namespace wBees.Services.JobsBussiness
{
    public class JobsService : IJobsService
    {
        private readonly ApplicationDbContext db;

        public JobsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ICollection<JobsTable> GetJobsList()
        {
            return this.db.Jobs.Select(j => new JobsTable
            {
                PublishedOn = j.PublishedOn.ToShortDateString(),
                Position = j.Position,
                Employer =j.PublishedBy.UserName,
                Type = j.EmploymentType.ToString()
            }).ToList();
        }
    }
}
