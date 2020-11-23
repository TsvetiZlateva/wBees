using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using wBees.Models;
using wBees.Models.Jobs;
using wBees.Services.JobsBusiness;

namespace wBees.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IJobsService jobsService;

        public HomeController(ILogger<HomeController> logger, IJobsService jobsService)
        {
            _logger = logger;
            this.jobsService = jobsService;
        }

        public IActionResult Index()
        {
            var jobsViewModel = this.jobsService.GetFullJobsList()
                .Take(10)
                .Select(x => new EditJobViewModel
                {
                    Id = x.Id,
                    PublishedOn = x.PublishedOn,
                    Position = x.Position,
                    Employer = x.Employer,
                    EmploymentType = x.EmploymentType
                }).ToList();

            return View(jobsViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
