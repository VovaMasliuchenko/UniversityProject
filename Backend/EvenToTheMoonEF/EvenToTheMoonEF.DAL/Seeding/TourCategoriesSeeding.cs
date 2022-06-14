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
    public class TourCategoriesSeeding : ISeeder<TourCategories>
    {
        private static readonly List<TourCategories> tourCategories = new List<TourCategories>()
        {
            new TourCategories()
            {
                Id = 1,
                TourCategorie = "Summer tours",
            }
        };

        public void Seed(EntityTypeBuilder<TourCategories> builder) => builder.HasData(tourCategories);
    }
}
