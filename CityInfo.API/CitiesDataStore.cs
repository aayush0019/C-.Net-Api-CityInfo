using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        static public CitiesDataStore Current = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Delhi",
                    Description = "Capital of India"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Ahmedabad",
                    Description = "Heritage City announced by UNESCO"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Bangalore",
                    Description = "Silicon Valley of India"
                }
            };
        }
    }
}
