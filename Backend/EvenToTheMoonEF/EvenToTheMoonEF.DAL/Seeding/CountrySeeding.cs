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
    public class CountrySeeding : ISeeder<Country>
    {
        private static readonly List<Country> countries = new List<Country>()
        {
            new Country()
            {
                Id = 1,
                CountryName = "England",
            }
        };

        public void Seed(EntityTypeBuilder<Country> builder) => builder.HasData(countries);
    }
}
