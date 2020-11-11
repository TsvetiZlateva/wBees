using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace wBees.Controllers
{
    public class JobsController : Controller
    {
        public IActionResult FindJobs()
        {
            return View();
        }
    }
}
