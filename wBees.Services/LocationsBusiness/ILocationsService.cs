using System.Collections.Generic;
using wBees.Services.DTO.Locations;

namespace wBees.Services.LocationsBusiness
{
    public interface ILocationsService
    {
        ICollection<LocationsDTO> GetAllLocations();
    }
}
