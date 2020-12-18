using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using wBees.Data.Models;
using wBees.Models.ComplexModels;
using wBees.Models.Industries;
using wBees.Models.Jobs;
using wBees.Services.IndustriesBusiness;
using wBees.Services.JobsBusiness;
using wBees.Services.LocationsBusiness;

namespace wBees.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobsService jobsService;
        private readonly IIndustriesService industriesService;
        private readonly ILocationsService locationsService;
        private readonly UserManager<ApplicationUser> userManager;

        public JobsController(IJobsService jobsService,
                              IIndustriesService industiesService,
                              ILocationsService locationsService,
                              UserManager<ApplicationUser> userManager)
        {
            this.jobsService = jobsService;
            this.industriesService = industiesService;
            this.locationsService = locationsService;
            this.userManager = userManager;
        }

        public IActionResult PublishJob()
        {
            var locationsFromDTO = this.locationsService.GetAllLocations();
            List<SelectListItem> locations = new List<SelectListItem>();

            foreach (var location in locationsFromDTO)
            {
                SelectListItem l = new SelectListItem()
                {
                    Value = location.Id.ToString(),
                    Text = location.Name
                };
                locations.Add(l);
            }

            var employmentTypesFromDTO = this.jobsService.GetEmploymentTypes();
            List<SelectListItem> employmentTypes = new List<SelectListItem>();
            foreach (var et in employmentTypesFromDTO)
            {
                SelectListItem e = new SelectListItem()
                {
                    Value = et.Id.ToString(),
                    Text = et.Name
                };
                employmentTypes.Add(e);
            }

            var seniorityLevelsFromDTO = this.jobsService.GetSeniorityLevels();
            List<SelectListItem> seniorityLevels = new List<SelectListItem>();
            foreach (var sl in seniorityLevelsFromDTO)
            {
                SelectListItem s = new SelectListItem()
                {
                    Value = sl.Id.ToString(),
                    Text = sl.Name
                };
                seniorityLevels.Add(s);
            }

            var industriesFromDTO = this.industriesService.GetAllIndustries();
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
                        Salary = job.Salary,
                        SubIndustry = job.SubIndustry.Name,
                        EmploymentType = job.EmploymentType.Name,
                        SeniorityLevel = job.SeniorityLevel.Name
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

            var viewModel = new JobFullInfoViewModel
            {
                Job = new EditJobViewModel(),
                Industries = industries,
                Locations = locations,
                EmploymentTypes = employmentTypes,
                SeniorityLevels = seniorityLevels
            };

            return this.View(viewModel);
        }

        [HttpPost]

        public async Task<IActionResult> PublishJob(JobFullInfoViewModel jobFullInfo)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var position = jobFullInfo.Job.Position;
            var employer = jobFullInfo.Job.Employer;
            var location = jobFullInfo.Job.Location;
            var description = jobFullInfo.Job.Description;
            var salary = jobFullInfo.Job.Salary;
            var subIndustry = jobFullInfo.Job.SubIndustry;
            var keywords = jobFullInfo.Job.Keywords;
            var employmentType = jobFullInfo.Job.EmploymentType;
            var seniorityLevel = jobFullInfo.Job.SeniorityLevel;
            var publishedBy = await this.userManager.GetUserAsync(this.User);

            var industries = jobFullInfo.Industries;


            await this.jobsService.PublishJobAsync(position, employer, location, description, salary, subIndustry, keywords, employmentType, seniorityLevel, publishedBy);

            return this.RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> JobsInfo(Guid id)
        {
            ApplicationUser user = await this.userManager.GetUserAsync(this.User);
            var job = this.jobsService.GetJobInfo(id, user.Id);
            var viewModel = new EditJobViewModel
            {
                Id = job.Id,
                Position = job.Position,
                Employer = job.Employer,
                Location = job.Location,
                Description = job.Description,
                Salary = job.Salary,
                //Keywords = job.Keywords,
                Industry = job.SubIndustry,
                EmploymentType = job.EmploymentType,
                SeniorityLevel = job.SeniorityLevel,
                Applied = job.Applied,
                Saved = job.Saved
            };

            return this.View(viewModel);
        }

        public IActionResult ListAllJobs()
        {
            var jobs = this.jobsService.GetFullJobsList().Select(job=> new EditJobViewModel
            {
                Id = job.Id,
                Position = job.Position,
                Employer = job.Employer,
                Location = job.Location,
                Description = job.Description.Length > 150 ? job.Description.Substring(0, 150) + "..." : job.Description,
                Salary = job.Salary,
                //Keywords = job.Keywords,
                Industry = job.SubIndustry,
                EmploymentType = job.EmploymentType,
                SeniorityLevel = job.SeniorityLevel
            }).ToList();
                       
            return this.View(jobs);
        }

        [HttpPost]
        public IActionResult ApplyForJob(Guid id)
        {


            return this.RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult SaveJob(Guid id)
        {


            return this.RedirectToAction("Index", "Home");
        }
    }
}
