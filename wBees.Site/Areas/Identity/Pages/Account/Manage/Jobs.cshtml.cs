using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wBees.Data.Models;
using wBees.Models.Jobs;
using wBees.Services.JobsBusiness;

namespace wBees.Areas.Identity.Pages.Account.Manage
{
    public class JobsModel : PageModel
    {
        private readonly IJobsService jobsService;
        private readonly UserManager<ApplicationUser> userManager;

        public JobsModel(IJobsService jobsService, UserManager<ApplicationUser> userManager)
        {
            this.jobsService = jobsService;
            this.userManager = userManager;
            this.Input = new List<EditJobViewModel>();
        }

        [BindProperty]
        public List<EditJobViewModel> Input { get; set; }

        private async Task LoadAsync(List<EditJobViewModel> jobs, ApplicationUser user)
        {
            user.UserJobs.Select(x => x.UserId);
            foreach (var job in jobs)
            {
                var id = job.Id;
                var publishedOn = job.PublishedOn;
                var position = job.Position;
                var employer = job.Employer;
                var type = job.EmploymentType;
                var description = job.Description;
                var location = job.Location;
                var seniority = job.SeniorityLevel;
                var userIds = job.UserIds;
                var applied = job.Applied;
                var saved = job.Saved;

                var userJob = new EditJobViewModel
                {
                    Id = id,
                    PublishedOn = publishedOn,
                    Position = position,
                    Employer = employer,
                    EmploymentType = type,
                    Description = description,
                    Location = location,
                    SeniorityLevel = seniority,
                    UserIds = userIds,
                    Applied = applied,
                    Saved = saved
                };

                Input.Add(userJob);
            }

        }

        public async Task<IActionResult> OnGet()
        {
            var user = await userManager.GetUserAsync(User);
            var jobs = this.jobsService.GetFullJobsList(user.Id)
                .Where(x => x.UserIds.Contains(user.Id))
                .Select(x => new EditJobViewModel
                {
                    Id = x.Id,
                    PublishedOn = x.PublishedOn,
                    Position = x.Position,
                    Employer = x.Employer,
                    EmploymentType = x.EmploymentType,
                    Description = x.Description,
                    Location = x.Location,
                    SeniorityLevel = x.SeniorityLevel,
                    UserIds = x.UserIds,
                    Applied = x.Applied,
                    Saved = x.Saved

                }).ToList();

            await LoadAsync(jobs, user);
            return Page();
        }

        //public IActionResult OnPost()
        //{
        //    var jobs = this.jobsService.GetFullJobsList().Select(x => new EditJobViewModel
        //    {
        //        Id = x.Id,
        //        PublishedOn = x.PublishedOn,
        //        Position = x.Position,
        //        Employer = x.Employer,
        //        EmploymentType = x.EmploymentType,
        //        Description = x.Description,
        //        Location = x.Location,
        //        SeniorityLevel = x.SeniorityLevel,
        //        UserIds = x.UserIds,
        //    }).ToList();

        //    if (!ModelState.IsValid)
        //    {
        //        Load(jobs);
        //        return Page();
        //    }

        //    //var firstName = Input.FirstName;
        //    //var lastName = Input.LastName;
        //    //var age = Input.Age;
        //    //var wantedSalary = Input.WantedSalary;
        //    //var interests = Input.Interests;

        //    //if (user.FirstName != firstName)
        //    //{
        //    //    user.FirstName = firstName;
        //    //    await this._userManager.UpdateAsync(user);
        //    //}
        //    //if (user.LastName != lastName)
        //    //{
        //    //    user.LastName = lastName;
        //    //    await this._userManager.UpdateAsync(user);
        //    //}
        //    //if (user.Age != age)
        //    //{
        //    //    user.Age = age;
        //    //    await this._userManager.UpdateAsync(user);
        //    //}
        //    //if (user.WantedSalary != wantedSalary)
        //    //{
        //    //    user.WantedSalary = wantedSalary;
        //    //    await this._userManager.UpdateAsync(user);
        //    //}
        //    //if (user.Interests != interests)
        //    //{
        //    //    user.Interests = interests;
        //    //    await this._userManager.UpdateAsync(user);
        //    //}

        //    //var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
        //    //if (Input.PhoneNumber != phoneNumber)
        //    //{
        //    //    var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
        //    //    if (!setPhoneResult.Succeeded)
        //    //    {
        //    //        StatusMessage = "Unexpected error when trying to set phone number.";
        //    //        return RedirectToPage();
        //    //    }
        //    //}

        //    //await _signInManager.RefreshSignInAsync(user);
        //    //StatusMessage = "Your profile has been updated";
        //    return RedirectToPage();
        //}
    }
}
