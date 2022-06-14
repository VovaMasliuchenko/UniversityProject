using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoon.DAL.Entities
{
    public class Sells
    {
        public int Id { get; set; }
        public DateTime DateOfSale { get; set; }
        public int SellsCount { get; set; }
        public int ID_Clients { get; set; }
        public int ID_Employee { get; set; }
        public int ID_Tour { get; set; }

    }
}
