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
    public class ToursRepository : GenericRepository<Tours>, IToursRepository
    {
        public ToursRepository(SqlConnection sqlConnection, IDbTransaction dbtransaction) : base(sqlConnection, dbtransaction, "Tours")
        {
        }

        public async Task<IEnumerable<Tours>> GetToursById(int Id)
        {
            using (SqlConnection sql = new SqlConnection(Connection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SelectTourById", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id", Id));
                    var response = new List<Tours>();
                    await sql.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue(reader));
                        }
                    }

                    return response;
                }
            }
        }
        private Tours MapToValue(SqlDataReader reader)
        {
            return new Tours()
            {
                Id = (int)reader["Id"],
                Tour = reader["Tour"].ToString(),
                Price = (int)reader["Price"],
                DateOfDepartue = (DateTime)reader["DateOfDepartue"],
                CityOfDepartue = reader["CityOfDepartue"].ToString(),
                CountOfPerson = (int)reader["CountOfPerson"],
                DaysAndNights = (int)reader["DaysAndNights"],
                ID_Country = (int)reader["ID_Country"],
                ID_Hotel = (int)reader["ID_Hotel"],
                ID_Discount = (int)reader["ID_Discount"],
                ID_Nutrition = (int)reader["ID_Nutrition"],
            };
        }
    }
}
