using Application.Common.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class EvenToTheMoonDbConnection : IEvenToTheMoonDbConnection
    {
        private const string ConnectionString = "mongodb://localhost:27017";
        private const string DatabaseName = "EvenToTheMoon";
        private const string SellsCollection = "Sells";

        public IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DatabaseName);
            return db.GetCollection<T>(collection);
        }
    }
}
