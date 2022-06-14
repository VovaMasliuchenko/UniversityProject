using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Configurations
{
    public class ClientsConfig : IEntityTypeConfiguration<Clients>
    {
        public void Configure(EntityTypeBuilder<Clients> builder)
        {
            new ClientsSeeding().Seed(builder);
        }
    }
}
