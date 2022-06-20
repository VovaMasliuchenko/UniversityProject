using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SellsEntity
    {
        [BsonId]
        public string Id { get; set; }
        public DateTime DateOfSale { get; set; }
        public int SellsCount { get; set; }
        public string ID_Clients { get; set; }
        public int ID_Tour { get; set; }
    }
}
