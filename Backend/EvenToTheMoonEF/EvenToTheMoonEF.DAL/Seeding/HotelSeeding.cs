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
    public class HotelSeeding : ISeeder<Hotel>
    {
        private static readonly List<Hotel> hotels = new List<Hotel>()
        {
            new Hotel()
            {
                Id = 1,
                HotelName = "Amazing",
                HotelType = "Big", 
                HotelClass = "5 stars", 
            }
        };

        public void Seed(EntityTypeBuilder<Hotel> builder) => builder.HasData(hotels);
    }
}
