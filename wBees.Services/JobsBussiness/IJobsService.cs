using System;
using System.Collections.Generic;
using wBees.Services.DTO;

namespace wBees.Services.JobsBussiness
{
    public interface IJobsService
    {
        ICollection<JobsTable> GetJobsList();
    }
}
