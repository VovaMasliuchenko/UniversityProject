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
    public class NutritionConfig : IEntityTypeConfiguration<Nutrition>
    {
        public void Configure(EntityTypeBuilder<Nutrition> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(e => e.TypeNutrition)
                   .HasMaxLength(20)
                   .IsRequired();
        }
    }
}
