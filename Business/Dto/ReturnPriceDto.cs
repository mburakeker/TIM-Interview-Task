using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto
{
    public class ReturnPriceDto
    {
        public int DaysOverdue { get; set; }
        public double Price { get; set; }
    }
}
