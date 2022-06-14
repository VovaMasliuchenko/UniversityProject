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
    public class SellsSeeding : ISeeder<Sells>
    {
        private static readonly List<Sells> sells = new List<Sells>()
        {
            new Sells()
            {
                Id = 1,
                DateOfSale = new DateTime(2021,6 ,11,10,0,0),
                SellsCount = 1,
                ID_Clients = "1",
                ID_Tour = 1,
            }
        };

        public void Seed(EntityTypeBuilder<Sells> builder) => builder.HasData(sells);
    }
}
