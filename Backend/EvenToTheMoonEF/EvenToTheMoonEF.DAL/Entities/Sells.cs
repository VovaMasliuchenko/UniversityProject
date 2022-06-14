using EvenToTheMoon_EF_.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Entities
{
    public class Sells : Entity
    {
        public DateTime DateOfSale { get; set; }
        public int SellsCount { get; set; }
        public string ID_Clients { get; set; }
        public Clients clients { get; set; }
        public int ID_Tour { get; set; }
        public Tours tours { get; set; }

    }
}
