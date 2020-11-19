using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using wBees.Services.DTO;

namespace wBees.Services.JobsBusiness
{
    public interface IJobsService
    {
        ICollection<JobsTableDTO> GetJobsList();

        Task PublishJobAsync(string position, string location, string description, string salary, string industry, List<string> keywords, string employmentType, string seniorityLevel);

        EditJobDTO GetJobInfo(Guid id);

    }
}
