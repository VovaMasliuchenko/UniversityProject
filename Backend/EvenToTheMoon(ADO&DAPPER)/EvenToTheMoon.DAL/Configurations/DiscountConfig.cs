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
    public class DiscountConfig : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.NameOfDiscount)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.Size)
                   .HasMaxLength(10)
                   .IsRequired();           
        }
    }
}
