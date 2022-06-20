using Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IEvenToTheMoonDbConnection
    {
        public IMongoCollection<T> ConnectToMongo<T>(in string collection);

    }
}
