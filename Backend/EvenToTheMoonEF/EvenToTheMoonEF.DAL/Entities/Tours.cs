using EvenToTheMoon_EF_.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Entities
{
    public class Tours : Entity
    {
        public string Tour { get; set; }
        public int Price { get; set; }
        public DateTime DateOfDepartue { get; set; }
        public string CityOfDepartue { get; set; }
        public int CountOfPerson { get; set; }
        public int DaysAndNights { get; set; }
        public int ID_Country { get; set; }
        public Country country { get; set; }
        public int ID_Hotel { get; set; }
        public Hotel hotel { get; set; }
        public int ID_Discount { get; set; }
        public Discount discount { get; set; }
        public int ID_Nutrition { get; set; }
        public Nutrition nutrition { get; set; }
        public int ID_Tour_Categories { get; set; }
        public TourCategories tourCategories { get; set; }

        public List<Reviews> reviews { get; set; }
        public List<Sells> sells { get; set; }



    }
}
