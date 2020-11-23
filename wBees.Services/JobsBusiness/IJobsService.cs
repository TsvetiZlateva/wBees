using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using wBees.Services.DTO.Jobs;

namespace wBees.Services.JobsBusiness
{
    public interface IJobsService
    {
        ICollection<JobsTableDTO> GetJobsList();

        ICollection<EditJobDTO> GetFullJobsList();

        Task PublishJobAsync(string position, string location, string description, string salary, string subIndustry, List<string> keywords, string employmentType, string seniorityLevel);

        EditJobDTO GetJobInfo(Guid id);

    }
}
