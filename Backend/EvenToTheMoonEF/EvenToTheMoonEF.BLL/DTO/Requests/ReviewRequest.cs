using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvenToTheMoon_EF_.DAL.Entities;

namespace EvenToTheMoon_EF_.BLL.DTO.Requests;

    public class ReviewRequest
    {
    public int id { get; set; }
    public string Review { get; set; }
}
