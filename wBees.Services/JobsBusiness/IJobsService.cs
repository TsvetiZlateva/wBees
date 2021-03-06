﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using wBees.Data.Models;
using wBees.Services.DTO.Jobs;

namespace wBees.Services.JobsBusiness
{
    public interface IJobsService
    {
        ICollection<JobsTableDTO> GetJobsList();

        ICollection<EditJobDTO> GetFullJobsList();

        ICollection<EditJobDTO> GetFullJobsList(string userId);

        Task PublishJobAsync(
            string position, 
            string employer, 
            string location, 
            string description, 
            int? salary, 
            string subIndustry, 
            string keywords, 
            string employmentType, 
            string seniorityLevel,
            ApplicationUser publishedBy);

        EditJobDTO GetJobInfo(Guid id, string userId);

        Task UpdateJobAsync(Guid id, EditJobDTO job);

        Task DeleteJobAsync(Guid id);

        ICollection<EmploymentTypeDTO> GetEmploymentTypes();

        ICollection<SeniorityLevelDTO> GetSeniorityLevels();

    }
}
