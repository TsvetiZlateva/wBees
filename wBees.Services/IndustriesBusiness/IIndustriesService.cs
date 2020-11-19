using System;
using System.Collections.Generic;
using System.Text;
using wBees.Data.Models;
using wBees.Services.DTO;

namespace wBees.Services.IndustriesBusiness
{
    public interface IIndustriesService
    {
        ICollection<IndustryDTO> GetAllIndustries();
    }
}
