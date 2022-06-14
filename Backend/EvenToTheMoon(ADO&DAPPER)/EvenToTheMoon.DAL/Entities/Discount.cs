using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoon.DAL.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public string NameOfDiscount { get; set; }
        public int Size { get; set; }
    }
}
