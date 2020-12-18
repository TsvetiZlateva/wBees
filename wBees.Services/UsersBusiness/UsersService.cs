using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wBees.Data;
using wBees.Data.Models;

namespace wBees.Services.UsersBusiness
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext db;

        public UsersService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task ApplyForJobAsync(Guid jobId, string userId)
        {
            var existingUserJob = this.db.UserJobs.FirstOrDefault(x => x.JobId == jobId && x.UserId == userId);

            if (existingUserJob != null)
            {
                existingUserJob.Applied = true;
                await this.db.SaveChangesAsync();
                return;
            }

            UserJobs uj = new UserJobs
            {
                JobId = jobId,
                UserId = userId,
                Applied = true
            };

            await this.db.UserJobs.AddAsync(uj);
            await this.db.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(Guid id)
        {
            string userId = id.ToString().ToLower();
            var user = this.db.Users.FirstOrDefault(x=> x.Id.ToLower() == userId);
            var userJobs = this.db.UserJobs.Where(x => x.UserId.ToLower() == userId);
            var userRoles = this.db.UserRoles.Where(x => x.UserId.ToLower() == userId);
            var userClaims = this.db.UserClaims.Where(x => x.UserId.ToLower() == userId);
            var userLogins = this.db.UserLogins.Where(x => x.UserId.ToLower() == userId);
            var userTokens = this.db.UserTokens.Where(x => x.UserId.ToLower() == userId);

            this.db.UserJobs.RemoveRange(userJobs);
            this.db.UserRoles.RemoveRange(userRoles);
            this.db.UserClaims.RemoveRange(userClaims);
            this.db.UserLogins.RemoveRange(userLogins);
            this.db.UserTokens.RemoveRange(userTokens);
            this.db.Users.Remove(user);

            await this.db.SaveChangesAsync();
        }

        public async Task SaveJobAsync(Guid jobId, string userId)
        {
            var existingUserJob = this.db.UserJobs.FirstOrDefault(x => x.JobId == jobId && x.UserId == userId);

            if (existingUserJob != null)
            {
                existingUserJob.Saved = true;
                await this.db.SaveChangesAsync();
                return;
            }

            UserJobs uj = new UserJobs
            {
                JobId = jobId,
                UserId = userId,
                Saved = true
            };

            await this.db.UserJobs.AddAsync(uj);
            await this.db.SaveChangesAsync();
        }
    }
}
