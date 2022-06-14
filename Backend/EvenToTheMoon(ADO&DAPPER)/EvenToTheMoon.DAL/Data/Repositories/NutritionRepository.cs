using EvenToTheMoon.DAL.Entities;
using EvenToTheMoon.DAL.Interfaces.Repositories;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoon.DAL.Data.Repositories
{
    public class NutritionRepository : GenericRepository<Nutrition>, INutritionRepository
    {
        public NutritionRepository(SqlConnection sqlConnection, IDbTransaction dbtransaction) : base(sqlConnection, dbtransaction, "Nutrition")
        {
        }

    }
}
