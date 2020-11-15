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
                .Select(x=> new JobsTableViewModel
                {
                    PublishedOn = x.PublishedOn,
                    Position = x.Position,
                    Employer = x.Employer,
                    Type = x.Type
                }).ToList();

            return View(jobsViewModel);
        }
    }
}
