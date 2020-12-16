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

        public IEnumerable<UsersTableDTO> GetUsersTable()
        {
            var users = this.db.Users.Select(user => new UsersTableDTO
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
            }).ToList();

            foreach (var user in users)
            {
                var rolesIds = this.db.UserRoles
                        .Where(x => x.UserId == user.Id)
                        .Select(x => x.RoleId)
                        .ToList();

                if (rolesIds != null)
                {                    
                    foreach (var role in rolesIds)
                    {
                        user.Roles.Add(this.db.Roles.Find(role).Name);
                    }
                }
            }

            return users;
        }
    }
}
