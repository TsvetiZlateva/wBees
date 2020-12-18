using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wBees.Data.Models;
using wBees.Services.UsersBusiness;

namespace wBees.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;
        private readonly UserManager<ApplicationUser> userManager;

        public UsersController(IUsersService usersService,  
                               UserManager<ApplicationUser> userManager)
        {
            this.usersService = usersService;
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> ApplyForJob(Guid id)
        {
            ApplicationUser user = await this.userManager.GetUserAsync(this.User);
            await this.usersService.ApplyForJobAsync(id, user.Id);
            return this.Redirect($"/Jobs/JobsInfo/{id}");
        }

        [HttpPost]
        public async Task<IActionResult> SaveJob(Guid id)
        {
            ApplicationUser user = await this.userManager.GetUserAsync(this.User);
            await this.usersService.SaveJobAsync(id, user.Id);
            return this.Redirect($"/Jobs/JobsInfo/{id}");
        }
    }
}
