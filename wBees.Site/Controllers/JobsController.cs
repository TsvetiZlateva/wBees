using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wBees.Models.Jobs;
using wBees.Services.JobsBussiness;

namespace wBees.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobsService jobsService;

        public JobsController(IJobsService jobsService)
        {
            this.jobsService = jobsService;
        }

        public IActionResult FindJobs()
        {
            var jobsViewModel = this.jobsService.GetJobsList()
                .Select(x => new JobsTableViewModel
                {
                    Id = x.Id,
                    PublishedOn = x.PublishedOn,
                    Position = x.Position,
                    Employer = x.Employer,
                    Type = x.Type
                }).ToList();

            return View(jobsViewModel);
        }

        public IActionResult PublishJob()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> PublishJob(EditJobViewModel job)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var position = job.Position;
            var location = job.Location;
            var description = job.Description;
            var salary = job.Salary;
            var industry = job.Industry;
            // var subIndustry = job.SubIndustry;
            var keywords = job.Keywords;
            var employmentType = job.EmploymentType;
            var seniorityLevel = job.SeniorityLevel;
            var publishedBy = this.User.Identity.Name;


            await this.jobsService.PublishJobAsync(position, location, description, salary, industry, keywords, employmentType, seniorityLevel);

            return this.RedirectToAction("Index", "Home");
        }

        public IActionResult JobsInfo(Guid id)
        {
            var job = this.jobsService.GetJobInfo(id);
            var viewModel = new EditJobViewModel
            {
                Id = job.Id,
                Position = job.Position,
                Location = job.Location,
                Description = job.Description,
                Salary = job.Salary.ToString(),
                Keywords = job.Keywords,
                Industry = job.Industry,
                EmploymentType = job.EmploymentType.ToString(),
                SeniorityLevel = job.SeniorityLevel.ToString()
            };

            return this.View(viewModel);
        }
    }
}
