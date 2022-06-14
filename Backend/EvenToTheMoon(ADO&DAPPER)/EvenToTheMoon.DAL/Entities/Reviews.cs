using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoon.DAL.Entities
{
    public class Reviews
    {
        public int Id { get; set; }
        public int ID_Clients { get; set; }
        public int ID_Tour { get; set; }


        public string Review { get; set; }
    }
}
