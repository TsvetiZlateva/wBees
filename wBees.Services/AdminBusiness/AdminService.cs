using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wBees.Data;
using wBees.Services.DTO.Administration;

namespace wBees.Services.AdminBusiness
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext db;

        public AdminService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public CountDTO GetCounts()
        {
            return new CountDTO
            {
                JobsCount = this.db.Jobs.Count(),
                UsersCount = this.db.Users.Count(),
                LocationsCount = this.db.Locations.Count(),
                IndustriesCount = this.db.Industries.Count()
            };
        }
    }
}
