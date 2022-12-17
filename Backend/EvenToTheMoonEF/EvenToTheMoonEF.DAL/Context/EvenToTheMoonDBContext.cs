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
    public class EvenToTheMoonDBContext : IdentityDbContext<User>
    {
        
        public DbSet<Reviews> Reviews { get; set; }

        public EvenToTheMoonDBContext(DbContextOptions<EvenToTheMoonDBContext> options)
              : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClientsConfig());
            modelBuilder.ApplyConfiguration(new ReviewConfig());
        }
    }
}
