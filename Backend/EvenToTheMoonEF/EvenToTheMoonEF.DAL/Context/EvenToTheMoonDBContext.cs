using EvenToTheMoonEF.DAL.Configurations;
using EvenToTheMoonEF.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Context
{
    public class EvenToTheMoonDBContext : IdentityDbContext<Clients>
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Nutrition> Nutrition { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Sells> Sells { get; set; }
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
            modelBuilder.ApplyConfiguration(new ClientsConfig());
            modelBuilder.ApplyConfiguration(new DiscountConfig());
            modelBuilder.ApplyConfiguration(new HotelConfig());
            modelBuilder.ApplyConfiguration(new NutritionConfig());
            modelBuilder.ApplyConfiguration(new ReviewConfig());
            modelBuilder.ApplyConfiguration(new SellsConfig());
            modelBuilder.ApplyConfiguration(new TourCategoriesConfig());
            modelBuilder.ApplyConfiguration(new ToursConfig());
        }
    }
}
