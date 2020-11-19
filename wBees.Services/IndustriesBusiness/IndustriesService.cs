using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wBees.Data;
using wBees.Data.Models;
using wBees.Services.DTO;

namespace wBees.Services.IndustriesBusiness
{
    public class IndustriesService : IIndustriesService
    {
        private readonly ApplicationDbContext db;

        public IndustriesService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ICollection<IndustryDTO> GetAllIndustries()
        {
            return this.db.Industries.Select(i => new IndustryDTO 
            {
                Id = i.Id,
                Name = i.Name,
                SubIndustries = i.SubIndustries.ToList(),
                Jobs = i.Jobs.ToList()
            }).ToList();
        }
    }
}
