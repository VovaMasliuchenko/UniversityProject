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
    public class DiscountSeeding : ISeeder<Discount>
    {
        private static readonly List<Discount> discounts = new List<Discount>()
        {
            new Discount()
            {
                Id = 1,
                NameOfDiscount = "Summer",
                Size = 10,
            }
        };

        public void Seed(EntityTypeBuilder<Discount> builder) => builder.HasData(discounts);
    }
}
