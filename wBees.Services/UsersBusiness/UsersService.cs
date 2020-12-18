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
