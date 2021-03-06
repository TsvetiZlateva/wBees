﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using wBees.Data.Models;

namespace wBees.Models.Jobs
{
    public class EditJobViewModel
    {
        public EditJobViewModel()
        {
            this.UserIds = new List<string>();
        }

        public Guid Id { get; set; }

        [MinLength(5)]
        [MaxLength(50)]
        public string Position { get; set; }

        [DisplayName("Published On")]
        public string PublishedOn { get; set; }

        [MaxLength(50)]
        public string Employer { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
     
        public int? Salary { get; set; }

        public string Keywords { get; set; }

       
        public string Industry { get; set; }

        [Required]
        public string SubIndustry { get; set; }

        [DisplayName("Employment Type")]
        public string EmploymentType { get; set; }

        [DisplayName("Seniority Level")]
        public string SeniorityLevel { get; set; }

        [DisplayName("Published By")]
        public ApplicationUser PublishedBy { get; set; }

        public bool Applied { get; set; }

        public bool Saved { get; set; }

        public List<string> UserIds { get; set; }

    }
}
