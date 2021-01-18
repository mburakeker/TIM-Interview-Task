using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dto;
using Business.TransactionManager.Abstract;
using DataAccess.EntityFramework;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Nager.Date;
using Nager.Date.Extensions;

namespace Business.TransactionManager.Concrete
{
    public class TransactionManager: ITransactionManager
    {
        private readonly ILogger<TransactionManager> _logger;
        private readonly LibraryContext _context;
        public TransactionManager(ILogger<TransactionManager> logger, LibraryContext context)
        {
            _logger = logger;
            _context = context;
        }
        public ReturnDateDto SuggestReturnDate(DateTime date, int days)
        {
            var countryCode = CountryCode.TR;
            var returnDate = date.AddDays(days);
            do
            {
                returnDate = returnDate.AddDays(1);
            } while (DateSystem.IsPublicHoliday(returnDate, countryCode) || returnDate.IsWeekend(countryCode));
            _logger.LogInformation($"Today is {DateTime.Today} and returned date is {returnDate}");
            return new ReturnDateDto(){ReturnDate = returnDate};
        }

        public async Task CreateBookTransaction(BookTransaction transaction)
        {
            var member = _context.Members.SingleOrDefault(m => m.MemberId == transaction.MemberId);
            if (member == null)
            {
                _logger.LogError($"Member with id {transaction.MemberId} not found!");
                throw new Exception("Member not found!");
            }

            var book = _context.Books.SingleOrDefault(b => b.IsbnId == transaction.IsbnId);
            if (book == null)
            {
                _logger.LogError($"Book with IsbnId {transaction.IsbnId} not found!");
                throw new Exception("Book not found!");
            }
            if (book.Count < 1)
            {
                _logger.LogError($"Book with IsbnId {transaction.IsbnId} is out of stock!");
                throw new Exception("Book out of stock!");
            }
            transaction.StartDate = DateTime.Today;
            _context.BookTransactions.Add(transaction);
            await _context.SaveChangesAsync();
            book.Count -= 1;
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task<List<BookTransaction>> GetBookTransactions() => await _context.BookTransactions.ToListAsync();
    }
}
