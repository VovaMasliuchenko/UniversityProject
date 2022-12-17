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
    public class TourCategoriesConfig : IEntityTypeConfiguration<TourCategories>
    {
        public void Configure(EntityTypeBuilder<TourCategories> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(e => e.TourCategorie)
                   .HasMaxLength(20)
                   .IsRequired();

        }
    }
}
