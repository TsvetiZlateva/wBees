using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wBees.Models.Administration;
using wBees.Models.Jobs;
using wBees.Services.AdminBusiness;
using wBees.Services.JobsBusiness;

namespace wBees.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Administration")]
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;
        private readonly IJobsService jobsService;

        public AdminController(IAdminService adminService, IJobsService jobsService)
        {
            this.adminService = adminService;
            this.jobsService = jobsService;
        }

        // GET: AdminController
        public ActionResult Index()
        {
            var counts = this.adminService.GetCounts();
            var viewModel = new AdminPanelViewModel
            {
                JobsCount = counts.JobsCount,
                UsersCount = counts.UsersCount,
                LocationsCount = counts.LocationsCount,
                IndustriesCount = counts.IndustriesCount
            };

            return View(viewModel);
        }

        public ActionResult JobsList()
        {
            var jobs = this.jobsService.GetFullJobsList();
            var viewModel = jobs.Select(x => new EditJobViewModel
            {
                PublishedOn = x.PublishedOn,
                Position = x.Position,
                Employer = x.Employer,
                EmploymentType = x.EmploymentType,
                Location = x.Location,
                Industry = x.Industry,
                SeniorityLevel = x.SeniorityLevel,
                Salary = x.Salary
            });

            return View(viewModel);
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
