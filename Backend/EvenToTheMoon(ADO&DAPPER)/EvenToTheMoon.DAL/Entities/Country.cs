﻿using EvenToTheMoon_EF_.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoon.DAL.Entities
{
    public class Country : Entity
    {
        public string CountryName { get; set; }
        public List<Tours> tours { get; set; }

    }
}
