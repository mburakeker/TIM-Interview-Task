using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Dto
{
    public class BookTransactionDailyReportDto
    {
        public string BookName { get; set; }
        public DateTime EndDate { get; set; }
        public int DaysOverdue { get; set; }
    }
}
