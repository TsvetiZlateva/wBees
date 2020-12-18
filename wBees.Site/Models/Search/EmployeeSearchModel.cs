using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wBees.Models.Search
{
    public class EmployeeSearchModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public int? WantedSalary { get; set; }

        [MaxLength(2000)]
        public string Interests { get; set; }
    }
}
