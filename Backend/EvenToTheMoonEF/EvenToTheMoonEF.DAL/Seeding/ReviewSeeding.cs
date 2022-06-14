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
    public class ReviewSeeding : ISeeder<Reviews>
    {
        private static readonly List<Reviews> reviews = new List<Reviews>()
        {
            new Reviews()
            {
                Id = 1,
                Review = "Not bad hotel!",
                ID_Clients = "1",
                ID_Tour = 1,
            }
        };

        public void Seed(EntityTypeBuilder<Reviews> builder) => builder.HasData(reviews);
    }
}
