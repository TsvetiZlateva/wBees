using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wBees.Services.DTO.Administration;

namespace wBees.Services.AdminBusiness
{
    public interface IAdminService
    {
        CountDTO GetCounts();
    }
}
