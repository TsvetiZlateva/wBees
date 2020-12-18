using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wBees.Services.UsersBusiness
{
    public interface IUsersService
    {
        Task ApplyForJobAsync(Guid jobId, string userId);

        Task SaveJobAsync(Guid jobId, string userId);

        Task DeleteUserAsync(Guid id);
    }
}
