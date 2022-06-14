using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvenToTheMoon_EF_.DAL.Entities;

namespace EvenToTheMoon_EF_.BLL.DTO.Requests;

    public class SellsRequest
    {
    public int id { get; set; }
    public DateTime DateOfSale { get; set; }
    public string SellsCount { get; set; }
}
