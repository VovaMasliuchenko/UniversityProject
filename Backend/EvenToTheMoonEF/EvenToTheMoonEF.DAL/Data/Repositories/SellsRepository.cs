using EvenToTheMoonEF.DAL.Context;
using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Data.Repositories
{
    public class SellsRepository : GenericRepository<Sells>, ISellsRepository
    {
        public SellsRepository(EvenToTheMoonDBContext dbContext) : base(dbContext)
        {
        }

    }
}
