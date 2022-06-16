using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.BLL.Validation
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            ValidationMessages = new List<string>();
        }
        public List<string> ValidationMessages { get; set; }
    }
}
