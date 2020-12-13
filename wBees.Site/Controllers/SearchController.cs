using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wBees.Models.ComplexModels;
using wBees.Models.Industries;
using wBees.Models.Jobs;
using wBees.Services.IndustriesBusiness;
using wBees.Services.JobsBusiness;
using wBees.Services.LocationsBusiness;
using wBees.Services.SearchBusiness;

namespace wBees.Controllers
{
    public class SearchController : Controller
    {
        private readonly IIndustriesService industriesService;
        private readonly ILocationsService locationsService;
        private readonly IJobsService jobsService;
        private readonly ISearchService searchService;

        public SearchController(IIndustriesService industriesService,
            ILocationsService locationsService,
            IJobsService jobsService,
            ISearchService searchService)
        {
            this.industriesService = industriesService;
            this.locationsService = locationsService;
            this.jobsService = jobsService;
            this.searchService = searchService;
        }
        public IActionResult FindJobs()
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

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult ListJobs(JobFullInfoViewModel jobFullInfo)
        {
            var position = jobFullInfo.Job.Position;
            var location = jobFullInfo.Job.Location;
            var salary = jobFullInfo.Job.Salary;           
            var keywords = jobFullInfo.Job.Keywords;
            var x = this.Request.Query["EmploymentTypes"].ToString();
            var employmentTypes = this.Request.Query["EmploymentTypes"].ToString() == "" ? null : this.Request.Query["EmploymentTypes"].ToString().Split(',').ToList(); 
            var seniorityLevels = this.Request.Query["SeniorityLevels"].ToString() == "" ? null : this.Request.Query["SeniorityLevels"].ToString().Split(',').ToList();
            var subIndustries = new List<string>();       
            var industries = jobFullInfo.Industries;

            var jobs = this.searchService.SearchInJobs(position, location, salary, subIndustries, keywords, employmentTypes, seniorityLevels);

            var jobsViewModel = jobs
                .Select(jobs => new EditJobViewModel
                {
                    Id = jobs.Id,
                    PublishedOn = jobs.PublishedOn.ToString("dd.MM.yyyy"),
                    Position = jobs.Position,
                    Employer = jobs.Employer,
                    EmploymentType = jobs.EmploymentType.Name
                })
                .ToList();

            return View(jobsViewModel);
        }

        [HttpGet]
        public IActionResult ListJobsFromFastSearch(string position, string keywords, string location)
        {
            var jobs = this.searchService.FastSearchInJobs(position, keywords, location);

            IEnumerable<EditJobViewModel> jobsViewModel = jobs
                .Select(jobs => new EditJobViewModel
                {
                    Id = jobs.Id,
                    PublishedOn = jobs.PublishedOn.ToString("dd.MM.yyyy"),
                    Position = jobs.Position,
                    Employer = jobs.Employer,
                    EmploymentType = jobs.EmploymentType.Name
                })
                .ToList();

            return View("ListJobs", jobsViewModel);
        }
    }
}
