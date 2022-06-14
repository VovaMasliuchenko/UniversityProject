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
    public class NutritionSeeding : ISeeder<Nutrition>
    {
        private static readonly List<Nutrition> nutritions = new List<Nutrition>()
        {
            new Nutrition()
            {
                Id = 1,
                TypeNutrition = "3 times", 
            }
        };

        public void Seed(EntityTypeBuilder<Nutrition> builder) => builder.HasData(nutritions);
    }
}
