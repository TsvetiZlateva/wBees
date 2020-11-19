using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wBees.Models.ComplexModels;
using wBees.Models.Industries;
using wBees.Models.Jobs;
using wBees.Services.IndustriesBusiness;
using wBees.Services.JobsBusiness;

namespace wBees.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobsService jobsService;
        private readonly IIndustriesService industiesService;

        public JobsController(IJobsService jobsService,
                              IIndustriesService industiesService)
        {
            this.jobsService = jobsService;
            this.industiesService = industiesService;
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
            var industriesFromDTO = this.industiesService.GetAllIndustries();
            List<IndustryViewModel> industries = new List<IndustryViewModel>();

            foreach (var industry in industriesFromDTO)
            {
                IndustryViewModel i = new IndustryViewModel();
                i.Id = industry.Id;
                i.Name = industry.Name;

                foreach (var job in industry.Jobs)
                {
                    i.Jobs.Add(new EditJobViewModel
                    {
                        Id = job.Id,
                        Position = job.Position,
                        Location = job.Location.Name,
                        Description = job.Description,
                        Salary = job.Salary.ToString(),
                        Industry = job.Industry.Name,
                        EmploymentType = job.EmploymentType.ToString(),
                        SeniorityLevel = job.SeniorityLevel.ToString()
                    });
                }

                foreach (var subIndustry in industry.SubIndustries)
                {
                    i.SubIndustries.Add(new SubIndustryViewModel
                    {
                        Id = subIndustry.Id,
                        Name = subIndustry.Name
                    });
                }

                industries.Add(i);
            }

            var viewModel = new JobIndustriesViewModel
            {
                Job = new EditJobViewModel(),
                Industries = industries
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> PublishJob(JobIndustriesViewModel jobWithIndustries)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var position = jobWithIndustries.Job.Position;
            var location = jobWithIndustries.Job.Location;
            var description = jobWithIndustries.Job.Description;
            var salary = jobWithIndustries.Job.Salary;
            var industry = jobWithIndustries.Job.Industry;
            var keywords = jobWithIndustries.Job.Keywords;
            var employmentType = jobWithIndustries.Job.EmploymentType;
            var seniorityLevel = jobWithIndustries.Job.SeniorityLevel;
            //var publishedBy = this.User.Identity.Name;

            var industries = jobWithIndustries.Industries;


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
