using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wBees.Services.DTO.Jobs;

namespace wBees.Services.LocationsBusiness
{
    public interface ILocationsService
    {
        ICollection<LocationsDTO> GetAllLocations();
    }
}
