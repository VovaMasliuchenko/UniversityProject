using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Requests;

    public class DiscountRequest
    {
    public int Id { get; set; }
    public string NameOfDiscount { get; set; }
    public int Size { get; set; }
}
