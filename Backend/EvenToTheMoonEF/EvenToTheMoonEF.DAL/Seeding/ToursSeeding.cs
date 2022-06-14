using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Seeding
{
    public class ToursSeeding : ISeeder<Tours>
    {
        private static readonly List<Tours> tours = new List<Tours>()
        {
            new Tours()
            {
                Id = 1,
                Tour = "Greatest Summer Tour",
                CityOfDepartue = "London",
                DateOfDepartue = new DateTime(2021,6 ,11,10,0,0),
                CountOfPerson = 3,
                DaysAndNights = 4,
                ID_Country = 1,
                ID_Discount = 1,
                ID_Hotel = 1,
                ID_Nutrition = 1,
                ID_Tour_Categories = 1,         
            }
        };

        public void Seed(EntityTypeBuilder<Tours> builder) => builder.HasData(tours);
    }
}
