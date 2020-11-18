using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wBees.Data;
using wBees.Data.Enums;
using wBees.Data.Models;
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

        public ICollection<JobsTableDTO> GetJobsList()
        {
            return this.db.Jobs.Select(j => new JobsTableDTO
            {
                Id = j.Id,
                PublishedOn = j.PublishedOn.ToShortDateString(),
                Position = j.Position,
                Employer = j.PublishedBy.UserName,
                Type = j.EmploymentType.ToString()
            }).ToList();
        }

        public async Task PublishJobAsync(
                                string position,
                                string location,
                                string description,
                                string salary,
                                string industry,
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
                Salary = decimal.Parse(salary == null ? "0" : salary),
                Industry = new Industry
                {
                    Name = "new"
                },
                //JobKeywords = (ICollection<JobKeyword>)keywords.ToList(),
                EmploymentType = (EmploymentType)Enum.Parse(typeof(EmploymentType), employmentType),
                SeniorityLevel = (SeniorityLevel)Enum.Parse(typeof(SeniorityLevel), seniorityLevel)
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
                Industry = job.Industry.Name,
                EmploymentType = job.EmploymentType.ToString(),
                SeniorityLevel = job.SeniorityLevel.ToString()
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
