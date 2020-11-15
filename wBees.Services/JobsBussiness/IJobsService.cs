using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using wBees.Services.DTO;

namespace wBees.Services.JobsBussiness
{
    public interface IJobsService
    {
        ICollection<JobsTableDTO> GetJobsList();

        Task PublishJobAsync(string position, string location, string description, string salary, string industry, string[] keywords, string employmentType, string seniorityLevel);
    }
}
