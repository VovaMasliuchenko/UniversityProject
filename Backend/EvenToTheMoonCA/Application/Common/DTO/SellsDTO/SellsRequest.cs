using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTO.SellsDTO
{
    public class SellsRequest
    {
        public string Id { get; set; }
        public DateTime DateOfSale { get; set; }
        public int SellsCount { get; set; }
        public string ID_Clients { get; set; }
        public int ID_Tour { get; set; }
    }
}
