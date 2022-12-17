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
    public class ReviewConfig : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(EntityTypeBuilder<Reviews> builder)
        {
            builder.HasKey(t => t.Id);


            builder.HasOne(t => t.clients)
                   .WithMany(d => d.reviews)
                   .HasForeignKey(k => k.ID_Clients);

            builder.Property(e => e.Review)
                   .HasMaxLength(100)
                   .IsRequired();


            new ReviewSeeding().Seed(builder);
        }
    }
}
