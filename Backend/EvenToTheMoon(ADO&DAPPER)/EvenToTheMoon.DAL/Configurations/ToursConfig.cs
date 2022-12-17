using EvenToTheMoon.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Configurations
{
    public class ToursConfig : IEntityTypeConfiguration<Tours>
    {
        public void Configure(EntityTypeBuilder<Tours> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(e => e.Tour)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.Price)
                  .HasMaxLength(20)
                  .IsRequired();

            builder.Property(e => e.DateOfDepartue)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.CityOfDepartue)
                  .HasMaxLength(20)
                  .IsRequired();

            builder.Property(e => e.CountOfPerson)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.DaysAndNights)
                  .HasMaxLength(20)
                  .IsRequired();

            builder.HasOne(t => t.country)
                   .WithMany(d => d.tours)
                   .HasForeignKey(k => k.ID_Country);

            builder.HasOne(t => t.hotel)
                   .WithMany(d => d.tours)
                   .HasForeignKey(k => k.ID_Hotel);

            builder.HasOne(t => t.discount)
                  .WithMany(d => d.tours)
                  .HasForeignKey(k => k.ID_Discount);

            builder.HasOne(t => t.nutrition)
                  .WithMany(d => d.tours)
                  .HasForeignKey(k => k.ID_Nutrition);

            builder.HasOne(t => t.tourCategories)
                   .WithMany(d => d.tours)
                   .HasForeignKey(k => k.ID_Tour_Categories);
            
        }
    }
}
