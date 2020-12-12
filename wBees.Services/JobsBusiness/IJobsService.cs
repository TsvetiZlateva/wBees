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

        Task PublishJobAsync(string position, string location, string description, int? salary, string subIndustry, string keywords, string employmentType, string seniorityLevel);

        EditJobDTO GetJobInfo(Guid id);

        ICollection<EmploymentTypeDTO> GetEmploymentTypes();

        ICollection<SeniorityLevelDTO> GetSeniorityLevels();

    }
}
