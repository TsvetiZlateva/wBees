using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wBees.Data;
using wBees.Services.DTO.Jobs;

namespace wBees.Services.LocationsBusiness
{
    public class LocationsService : ILocationsService
    {
        private readonly ApplicationDbContext db;

        public LocationsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ICollection<LocationsDTO> GetAllLocations()
        {
            return this.db.Locations.Select(l => new LocationsDTO
            {
                Id = l.Id,
                Name = l.Name
            })
            .OrderBy(l => l.Name)
            .ToList();
        }
    }
}
