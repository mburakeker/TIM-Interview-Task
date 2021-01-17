using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dto;
using Business.TransactionManager.Abstract;
using Microsoft.Extensions.Logging;
using Nager.Date;
using Nager.Date.Extensions;

namespace Business.TransactionManager.Concrete
{
    public class TransactionManager: ITransactionManager
    {
        private readonly ILogger<TransactionManager> _logger;
        public TransactionManager(ILogger<TransactionManager> logger)
        {
            _logger = logger;
        }
        public ReturnDateDto SuggestReturnDate(DateTime date, int days)
        {
            var countryCode = CountryCode.TR;
            var returnDate = date.AddDays(days);
            do
            {
                returnDate = returnDate.AddDays(1);
            } while (DateSystem.IsPublicHoliday(returnDate, countryCode) || returnDate.IsWeekend(countryCode));
            
            return new ReturnDateDto(){ReturnDate = returnDate};
        }
    }
}
