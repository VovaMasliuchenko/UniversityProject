using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Requests;

    public class ToursRequest
    {
    public int Id { get; set; }
    public string Tour { get; set; }
    public int Price { get; set; }
    public DateTime DateOfDepartue { get; set; }
    public string CityOfDepartue { get; set; }
    public int CountOfPerson { get; set; }
    public int DaysAndNights { get; set; }
    public int ID_Country { get; set; }
    public int ID_Hotel { get; set; }
    public int ID_Discount { get; set; }
    public int ID_Nutrition { get; set; }
    public int ID_Tour_Categories { get; set; }
}
