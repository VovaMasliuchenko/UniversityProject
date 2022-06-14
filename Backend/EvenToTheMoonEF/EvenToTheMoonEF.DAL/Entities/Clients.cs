using EvenToTheMoon_EF_.DAL.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Entities
{
    public class Clients : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public List<Reviews> reviews { get; set; }
        public List<Sells> sells { get; set; }

    }
}
