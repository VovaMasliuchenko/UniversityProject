using EvenToTheMoonEF.DAL.Seeding;
using EvenToTheMoonEF.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Configurations
{
    public class SellsConfig : IEntityTypeConfiguration<Sells>
    {
        public void Configure(EntityTypeBuilder<Sells> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(e => e.DateOfSale)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.SellsCount)
                  .HasMaxLength(20)
                  .IsRequired();

            builder.HasOne(t => t.clients)
                   .WithMany(d => d.sells)
                   .HasForeignKey(k => k.ID_Clients);

            builder.HasOne(t => t.tours)
                  .WithMany(d => d.sells)
                  .HasForeignKey(k => k.ID_Tour);

            new SellsSeeding().Seed(builder);
        }
    }
}
