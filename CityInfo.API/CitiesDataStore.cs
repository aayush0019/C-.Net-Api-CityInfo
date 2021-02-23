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
                    Description = "Capital of India",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Taj Mahal",
                            Description = "One of the 7 wonders of the world."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Qutub Minar",
                            Description = "The tallest minaret in the world built of bricks."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Ahmedabad",
                    Description = "Heritage City announced by UNESCO",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Sabarmati Ashram",
                            Description = "Mahatma Gandhiji's Museum"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Bangalore",
                    Description = "Silicon Valley of India",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Lalbagh Botanical Garden",
                            Description = "Old botanical garden"
                        }
                    }
                }
            };
        }
    }
}
