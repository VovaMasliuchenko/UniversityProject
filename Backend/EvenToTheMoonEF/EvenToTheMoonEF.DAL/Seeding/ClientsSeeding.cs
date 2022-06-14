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
    public class ClientsSeeding : ISeeder<Clients>
    {
        private static readonly List<Clients> clients = new List<Clients>()
        {
            new Clients()
            {
                Id = "1",
                UserName = "Antony Marks",
                PhoneNumber = "+380683456781",
                Email = "email@gmail.com",
            },
        };

        public void Seed(EntityTypeBuilder<Clients> builder) => builder.HasData(clients);
    }
}
