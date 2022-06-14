using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Requests;

    public class HotelRequest
    {
    public int Id { get; set; }
    public string HotelName { get; set; }
    public string HotelType { get; set; }
    public string HotelClass { get; set; }
}
