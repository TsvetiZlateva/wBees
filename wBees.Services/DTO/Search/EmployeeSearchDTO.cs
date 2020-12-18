using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wBees.Services.DTO.Search
{
    public class EmployeeSearchDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public int? WantedSalary { get; set; }

   
        public string Interests { get; set; }
    }
}
