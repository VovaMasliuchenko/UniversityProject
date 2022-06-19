using EvenToTheMoon_EF_.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Entities
{
    public class Reviews : Entity
    {
        public string ID_Clients { get; set; }
        public User clients { get; set; }
        public Tours tours { get; set; }
        public int ID_Tour { get; set; }
        public string Review { get; set; }
    }
}
