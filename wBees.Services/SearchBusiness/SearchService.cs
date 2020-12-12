using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wBees.Data;
using wBees.Data.Models;
using wBees.Services.DTO.Jobs;

namespace wBees.Services.SearchBusiness
{
    public class SearchService : ISearchService
    {
        private readonly ApplicationDbContext db;

        public SearchService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ICollection<Job> SearchInJobs(
            string position,
            string location,
            int? salary,
            List<string> subIndustry,
            string keywords,
            List<string> employmentType,
            List<string> seniorityLevel)
        {
            List<string> keys = keywords?.Split(',').ToList();
            List<Keyword> kwords = new List<Keyword>();
            if (keys != null)
            {
                foreach (var k in keys)
                {
                    var kword = this.db.Keywords.FirstOrDefault(x => x.Name == k);
                    kwords.Add(kword);
                }
            }


            var jobs = this.db.Jobs
                .Where(x => x.Position.Contains(position) //&&
                //x.LocationId == Guid.Parse(location) &&
                /*x.Salary == salary*/)
              .ToList();

            if (kwords != null)
            {
                foreach (var kw in kwords)
                {
                    jobs = jobs.Where(x => x.JobKeywords.Any(k => k.KeywordId == kw.Id)).ToList();
                }
            }

            if (subIndustry != null)
            {
                foreach (var si in subIndustry)
                {
                    jobs = jobs.Where(x => x.SubIndustryId == Guid.Parse(si)).ToList();

                }
            }

            if (employmentType != null)
            {
                foreach (var et in employmentType)
                {
                    jobs = jobs.Where(x => x.EmploymentTypeId == Guid.Parse(et)).ToList();

                }
            }

            if (seniorityLevel != null)
            {
                foreach (var sl in seniorityLevel)
                {
                    jobs = jobs.Where(x => x.SeniorityLevelId == Guid.Parse(sl)).ToList();

                }
            }

            //jobs = jobs.Select(job => new EditJobDTO()
            //{
            //    Id = job.Id,
            //    Position = job.Position,
            //    Location = job.Location.Name,
            //    Description = job.Description,
            //    Salary = job.Salary,
            //    SubIndustry = job.SubIndustry.Name,
            //    EmploymentType = job.EmploymentType.Name,
            //    SeniorityLevel = job.SeniorityLevel.Name
            //}).ToList();

            return jobs;
        }
    }
}
