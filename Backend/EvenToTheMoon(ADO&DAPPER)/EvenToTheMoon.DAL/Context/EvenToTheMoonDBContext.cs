using EvenToTheMoonEF.DAL.Configurations;
using EvenToTheMoon.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Context
{
    public class EvenToTheMoonDBContext : DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Nutrition> Nutrition { get; set; }
        public DbSet<TourCategories> TourCategories { get; set; }
        public DbSet<Tours> Tours { get; set; }

        public EvenToTheMoonDBContext(DbContextOptions<EvenToTheMoonDBContext> options)
              : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new DiscountConfig());
            modelBuilder.ApplyConfiguration(new HotelConfig());
            modelBuilder.ApplyConfiguration(new NutritionConfig());
            modelBuilder.ApplyConfiguration(new TourCategoriesConfig());
            modelBuilder.ApplyConfiguration(new ToursConfig());
        }
    }
}
