using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly IIndustriesService industiesService;
        private readonly ILocationsService locationsService;

        public JobsController(IJobsService jobsService,
                              IIndustriesService industiesService,
                              ILocationsService locationsService)
        {
            this.jobsService = jobsService;
            this.industiesService = industiesService;
            this.locationsService = locationsService;
        }

        //public IActionResult FindJobs()
        //{
        //    var jobsViewModel = this.jobsService.GetJobsList()
        //        .Select(x => new JobsTableViewModel
        //        {
        //            Id = x.Id,
        //            PublishedOn = x.PublishedOn,
        //            Position = x.Position,
        //            Employer = x.Employer,
        //            Type = x.Type
        //        }).ToList();

        //    return View(jobsViewModel);
        //}

        public IActionResult FindJobs()
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

            //var jobs = this.jobsService.GetFullJobsList()
            //               .Take(10)
            //               .Select(x => new EditJobViewModel
            //               {
            //                   Id = x.Id,
            //                   PublishedOn = x.PublishedOn,
            //                   Position = x.Position,
            //                   Employer = x.Employer,
            //                   Type = x.Type
            //               }).ToList();

            var viewModel = new JobFullInfoViewModel
            {
                Job = new EditJobViewModel(),
                Industries = industries
            };



            return View(viewModel);
        }

        public IActionResult PublishJob()
        {
            var locationsFromDTO = this.locationsService.GetAllLocations();
            //var locations = new List<LocationViewModel>();
            List<SelectListItem> locations = new List<SelectListItem>();

            foreach (var location in locationsFromDTO)
            {
                SelectListItem l = new SelectListItem()
                {
                    //Id = location.Id,
                    //Name = location.Name
                    Value = location.Id.ToString(),
                    Text = location.Name
                };
                locations.Add(l);
            }

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
                Locations = locations
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> PublishJob(JobFullInfoViewModel jobWithIndustries)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var position = jobWithIndustries.Job.Position;
            var location = jobWithIndustries.Job.Location;
            var description = jobWithIndustries.Job.Description;
            var salary = jobWithIndustries.Job.Salary;
            var subIndustry = jobWithIndustries.Job.SubIndustry;
            var keywords = jobWithIndustries.Job.Keywords;
            var employmentType = jobWithIndustries.Job.EmploymentType;
            var seniorityLevel = jobWithIndustries.Job.SeniorityLevel;
            //var publishedBy = this.User.Identity.Name;

            var industries = jobWithIndustries.Industries;


            await this.jobsService.PublishJobAsync(position, location, description, salary, subIndustry, keywords, employmentType, seniorityLevel);

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
                Industry = job.SubIndustry,
                EmploymentType = job.EmploymentType,
                SeniorityLevel = job.SeniorityLevel
            };

            return this.View(viewModel);
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
