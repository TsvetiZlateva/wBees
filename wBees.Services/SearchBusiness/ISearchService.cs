using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wBees.Data.Models;
using wBees.Services.DTO.Jobs;
using wBees.Services.DTO.Search;

namespace wBees.Services.SearchBusiness
{
    public interface ISearchService
    {
        ICollection<Job> SearchInJobs(
            string position, 
            string location,
            int? salary,
            List<string> subIndustry, 
            string keywords, 
            List<string> employmentType,
            List<string> seniorityLevel);

        ICollection<Job> FastSearchInJobs(string position, string keywords, string location);

        ICollection<EmployeeSearchDTO> SearchInUsers(int? age, int? wantedSalary, string interests);
    }
}
