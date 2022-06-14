using EvenToTheMoon_EF_.DAL.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoon_EF_.DAL.Entities.Base { 
    public class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
