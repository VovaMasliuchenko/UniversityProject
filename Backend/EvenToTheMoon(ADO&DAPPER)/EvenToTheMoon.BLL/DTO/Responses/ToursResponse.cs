using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Responses
{
    public class ToursResponse
    {
        public string Tour { get; set; }
        public int Price { get; set; }
        public DateTime DateOfDepartue { get; set; }
        public string CityOfDepartue { get; set; }
        public int CountOfPerson { get; set; }
        public int DaysAndNights { get; set; }
        
        /*public string CountryName { get; set; }
        public string Name { get; set; }
        public string NameOfDiscount { get; set; }
        public string TypeNutrition { get; set; }
        public string TourCategorie { get; set; }
        */
        
    }
}
