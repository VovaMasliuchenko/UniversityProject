﻿using EvenToTheMoonEF.DAL.Seeding;
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
    public class HotelConfig : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(e => e.HotelName)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.HotelType)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.HotelClass)
                   .HasMaxLength(20)
                   .IsRequired();


            new HotelSeeding().Seed(builder);
        }
    }
}
