using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wBees.Models.Administration;
using wBees.Models.ComplexModels;
using wBees.Models.Industries;
using wBees.Models.Jobs;
using wBees.Services.AdminBusiness;
using wBees.Services.DTO.Jobs;
using wBees.Services.IndustriesBusiness;
using wBees.Services.JobsBusiness;
using wBees.Services.LocationsBusiness;
using wBees.Services.UsersBusiness;

namespace wBees.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Administration")]
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;
        private readonly IJobsService jobsService;
        private readonly IIndustriesService industriesService;
        private readonly ILocationsService locationsService;
        private readonly IUsersService usersService;

        public AdminController(IAdminService adminService,
                               IJobsService jobsService,
                               IIndustriesService industriesService,
                               ILocationsService locationsService,
                               IUsersService usersService)
        {
            this.adminService = adminService;
            this.jobsService = jobsService;
            this.industriesService = industriesService;
            this.locationsService = locationsService;
            this.usersService = usersService;
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
                Id = x.Id,
                PublishedOn = x.PublishedOn,
                Position = x.Position,
                Employer = x.Employer,
                EmploymentType = x.EmploymentType,
                Location = x.Location,
                Industry = x.Industry,
                SeniorityLevel = x.SeniorityLevel,
                Salary = x.Salary
            });

            return this.View(viewModel);
        }

        public ActionResult UsersList()
        {           
            var viewModel = this.adminService.GetUsersTable().Select(user => new UsersTableViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
                Roles = user.Roles
            });

            return this.View(viewModel);
        }

        // GET: AdminController/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var job = this.jobsService.GetJobInfo((Guid)id, null);

            if (job == null)
            {
                return this.NotFound();
            }
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
                SeniorityLevel = job.SeniorityLevel
            };

            return this.View(viewModel);
        }

        // GET: AdminController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: AdminController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: AdminController/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

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

                foreach (var j in industry.Jobs)
                {
                    i.Jobs.Add(new EditJobViewModel
                    {
                        Id = j.Id,
                        Position = j.Position,
                        Location = j.Location.Name,
                        Description = j.Description,
                        Salary = j.Salary,
                        SubIndustry = j.SubIndustry.Name,
                        EmploymentType = j.EmploymentType.Name,
                        SeniorityLevel = j.SeniorityLevel.Name
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

            var job = this.jobsService.GetJobInfo((Guid)id, null);

            if (job == null)
            {
                return this.NotFound();
            }
            var jobViewModel = new EditJobViewModel
            {
                Id = job.Id,
                Position = job.Position,
                Employer = job.Employer,
                Location = job.Location,
                Description = job.Description,
                Salary = job.Salary,
                Keywords = String.Join(',', job.Keywords),
                SubIndustry = job.SubIndustry,
                EmploymentType = job.EmploymentType,
                SeniorityLevel = job.SeniorityLevel
            };

            var viewModel = new JobFullInfoViewModel
            {
                Job = jobViewModel,
                Industries = industries,
                Locations = locations,
                EmploymentTypes = employmentTypes,
                SeniorityLevels = seniorityLevels
            };

            return this.View(viewModel);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Guid id, JobFullInfoViewModel model)
        {
            if (id != model.Job.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {              
                var job = new EditJobDTO
                {
                    Position = model.Job.Position,
                    Employer = model.Job.Employer,
                    Location = model.Job.Location,
                    Description = model.Job.Description,
                    Salary = model.Job.Salary,
                    SubIndustry = model.Job.SubIndustry,
                    //Keywords= model.Job.Keywords?.Split(',').ToList(),
                    EmploymentType = model.Job.EmploymentType,
                    SeniorityLevel = model.Job.SeniorityLevel
                };

                try
                {
                    await this.jobsService.UpdateJobAsync(id, job);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return RedirectToAction(nameof(JobsList));
            }

            return View();

        }

        // GET: AdminController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                await this.jobsService.DeleteJobAsync(id);
                return RedirectToAction(nameof(JobsList));
            }
            catch (Exception ex)
            {
                //return this.RedirectToPage("/Views/Shared/Error");
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteUser(Guid id)
        {
            try
            {
                await this.usersService.DeleteUserAsync(id);
                return RedirectToAction(nameof(UsersList));
            }
            catch (Exception ex)
            {
                //return this.RedirectToPage("/Views/Shared/Error");
                throw new Exception(ex.Message);
            }
        }
    }
}
