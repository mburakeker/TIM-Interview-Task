using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dto;
using Business.ReportManager.Abstract;
using DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Business.ReportManager.Concrete
{
    public class ReportManager: IReportManager
    {
        private readonly ILogger<ReportManager> _logger;
        private readonly LibraryContext _context;
        public ReportManager(ILogger<ReportManager> logger, LibraryContext context)
        {
            _logger = logger;
            _context = context;
        }

        internal bool IsDatetimePastOrComingSoon(DateTime endDate,int soonAsDays)
        {
            return (endDate - DateTime.Now).Days <= soonAsDays;
        }
        public async Task<List<BookTransactionDailyReportDto>> GetDailyReport(int upcomingDays)
        {
            var today = DateTime.Today;
            var activeTransactions = await _context.BookTransactions
                .Include(bt => bt.Book)
                .Include(bt => bt.Member)
                .Where(bt => bt.IsActive)
                .ToListAsync();
            var filteredTransactions = activeTransactions
                .Where(bt=> IsDatetimePastOrComingSoon(bt.EndDate,7))
                .Select(bt=>new BookTransactionDailyReportDto()
                {
                    BookName = bt.Book.BookName,
                    EndDate = bt.EndDate,
                    DaysOverdue = (today - bt.EndDate).Days
                }).ToList();

            return filteredTransactions;
        }
    }
}
