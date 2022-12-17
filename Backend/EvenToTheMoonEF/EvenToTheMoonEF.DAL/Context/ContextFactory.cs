using EvenToTheMoonEF.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<EvenToTheMoonDBContext>
    {
        public EvenToTheMoonDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EvenToTheMoonDBContext>();

            optionsBuilder.UseSqlServer("Server=DESKTOP-7OJO846\\SQLEXPRESS; Database=EvenToTheMoonEntityFramework;Integrated Security=True;");
            return new EvenToTheMoonDBContext(optionsBuilder.Options);
        }
    }
}
