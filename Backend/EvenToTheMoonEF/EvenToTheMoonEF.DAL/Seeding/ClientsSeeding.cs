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
    public class ClientsSeeding : ISeeder<User>
    {
        private static readonly List<User> clients = new List<User>()
        {
            new User()
            {
                Id = "1",
                UserName = "Antony Marks",
                PhoneNumber = "+380683456781",
                Email = "email@gmail.com",
            },
        };

        public void Seed(EntityTypeBuilder<User> builder) => builder.HasData(clients);
    }
}
