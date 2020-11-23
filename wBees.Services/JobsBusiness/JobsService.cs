using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wBees.Data;
using wBees.Data.Models;
using wBees.Services.DTO.Jobs;

namespace wBees.Services.JobsBusiness
{
    public class JobsService : IJobsService
    {
        private readonly ApplicationDbContext db;

        public JobsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ICollection<JobsTableDTO> GetJobsList()
        {
            return this.db.Jobs.Select(j => new JobsTableDTO
            {
                Id = j.Id,
                PublishedOn = j.PublishedOn.ToShortDateString(),
                Position = j.Position,
                Employer = j.PublishedBy.UserName,
                Type = j.EmploymentType.Name
            }).ToList();
        }

        public ICollection<EditJobDTO> GetFullJobsList()
        {
            return this.db.Jobs.Select(job => new EditJobDTO
            {
                Id = job.Id,
                Position = job.Position,
                PublishedOn = job.PublishedOn.ToShortDateString(),
                Employer = job.PublishedBy.UserName,
                Location = job.Location.Name,
                Description = job.Description,
                Salary = job.Salary,
                SubIndustry = job.SubIndustry.Name,
                EmploymentType = job.EmploymentType.Name,
                SeniorityLevel = job.SeniorityLevel.Name
            }).ToList();
        }

        public async Task PublishJobAsync(
                                string position,
                                string location,
                                string description,
                                string salary,
                                string subIndustry,
                                List<string> keywords,
                                string employmentType,
                                string seniorityLevel
                                )
        {
            var job = new Job
            {
                PublishedOn = DateTime.Now,
                //PublishedBy = "280F2D5B-889F-4E78-A284-C8C9E2EFAC48"
                Position = position,
                Location = new Location
                {
                    Name = "new"
                },
                Description = description,
                Salary = int.Parse(salary == null ? "0" : salary),
                SubIndustryId = Guid.Parse(subIndustry),
                EmploymentTypeId = Guid.Parse(employmentType),
                SeniorityLevelId = Guid.Parse(seniorityLevel)
                //SubIndustry = new SubIndustry
                //{
                //    Name = "new"
                //},
                //JobKeywords = (ICollection<JobKeyword>)keywords.ToList(),
                //EmploymentType = employmentType,
                //SeniorityLevel = (SeniorityLevel)Enum.Parse(typeof(SeniorityLevel), seniorityLevel)
            };

            this.db.Jobs.Add(job);
            await this.db.SaveChangesAsync();
        }

        public EditJobDTO GetJobInfo(Guid id)
        {
            var job = this.db.Jobs.FirstOrDefault(j => j.Id == id);
            //var i = this.db.Industries.Find(job.IndustryId);
            //var l = this.db.Locations.Find(job.LocationId);
            var jobInfo = new EditJobDTO()
            {
                Id = job.Id,
                Position = job.Position,
                Location = job.Location.Name,
                Description = job.Description,
                Salary = job.Salary,
                SubIndustry = job.SubIndustry.Name,
                EmploymentType = job.EmploymentType.Name,
                SeniorityLevel = job.SeniorityLevel.Name
            };
            jobInfo.LocationId = job.LocationId;
            foreach (var item in job.JobKeywords)
            {
                jobInfo.Keywords.Add(item.Keyword.Name);
            }

            return jobInfo;
        }

       
    }
}
