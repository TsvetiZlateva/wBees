using System;
using System.ComponentModel.DataAnnotations;

namespace wBees.Models.Industries
{
    public class SubIndustryViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual IndustryViewModel Industry { get; set; }
    }
}