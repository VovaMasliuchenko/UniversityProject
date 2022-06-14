using EvenToTheMoon_EF_.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Entities
{
    public class Hotel : Entity
    {
        public string HotelName { get; set; }
        public string HotelType { get; set; }
        public string HotelClass { get; set; }
        public List<Tours> tours { get; set; }
    }
}
