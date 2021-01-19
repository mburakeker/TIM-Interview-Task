using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dto;

namespace Business.ReportManager.Abstract
{
    public interface IReportManager
    {
        Task<List<BookTransactionDailyReportDto>> GetDailyReport(int upcomingDays);
    }
}
