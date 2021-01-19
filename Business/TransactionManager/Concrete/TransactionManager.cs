using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dto;
using Business.TransactionManager.Abstract;
using DataAccess.EntityFramework;
using Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Nager.Date;
using Nager.Date.Extensions;
using Utility;

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
            #region Validate if member exists
            var member = _context.Members.SingleOrDefault(m => m.MemberId == transaction.MemberId);
            if (member == null)
            {
                _logger.LogError($"Member with id {transaction.MemberId} not found!");
                throw new Exception("Member not found!");
            }
            #endregion
            #region Validate if book with given Isbn Id exists in DB
            var book = _context.Books.SingleOrDefault(b => b.IsbnId == transaction.IsbnId);
            if (book == null)
            {
                _logger.LogError($"Book with IsbnId {transaction.IsbnId} not found!");
                throw new Exception("Book not found!");
            }
            #endregion
            #region Validate if there are enough books to lend
            if (book.Count < 1)
            {
                _logger.LogError($"Book with IsbnId {transaction.IsbnId} is out of stock!");
                throw new Exception("Book out of stock!");
            }
            #endregion
            transaction.StartDate = DateTime.Today;
            transaction.IsActive = true;
            _context.BookTransactions.Add(transaction);
            await _context.SaveChangesAsync();
            #region Decrease Book Count
            book.Count -= 1;
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            #endregion
        }
        public async Task ReturnBook(int transactionId)
        {
            #region Set Return Date and Complete Transaction
            var transaction = await _context.BookTransactions.SingleOrDefaultAsync(bt => bt.TransactionId == transactionId);
            if (transaction == null)
            {
                _logger.LogError($"Transaction with Id {transactionId} has not found!");
                throw new Exception("Transaction has not found!");
            }
            transaction.ReturnDate = DateTime.Now;
            transaction.IsActive = false;
            _context.BookTransactions.Update(transaction);
            await _context.SaveChangesAsync();
            #endregion
            #region Increase Book Count after returning the book
            var book = await _context.Books.SingleOrDefaultAsync(b => b.IsbnId == transaction.IsbnId);
            if (book == null)
            {
                _logger.LogError($"Book with ISBN ID {transaction.IsbnId} has not found in DB");
                throw new Exception("Book not found in database!");
            }
            book.Count += 1;
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            #endregion
        }

        public async Task<List<GetBookTransactionDto>> GetBookTransactions()
        {
            var transactions =  await _context.BookTransactions.Include(bt => bt.Book).Include(bt => bt.Member).ToListAsync();
            return transactions.Adapt<List<GetBookTransactionDto>>();
        }
        public async Task<ReturnPriceDto> GetReturnPriceByTransactionId(int transactionId)
        {
            var transaction = await _context.BookTransactions.SingleOrDefaultAsync(bt=>bt.TransactionId == transactionId);
            if (transaction == null)
            {
                _logger.LogError($"Book Transaction with Transaction Id {transactionId} not found!");
                throw new Exception("Book Transaction not found!");
            }
            if (transaction.IsActive == false)
            {
                _logger.LogError("Book transaction is not active!");
                throw new Exception("Book transaction is not active!");
            }
            var daysOverdue = (DateTime.Now - transaction.EndDate).Days;
            var returnPriceDto = new ReturnPriceDto()
            {
                DaysOverdue = daysOverdue,
                Price = 0
            };
            if (daysOverdue >= 0)
            {
                returnPriceDto.Price = Math.Round(Utils.CalculatePrice(daysOverdue), 2, MidpointRounding.ToZero);
            }
            return returnPriceDto;
        }
        public async Task<List<BookTransaction>> SearchBookTransactions(string search) => await _context.BookTransactions
            .Include(bt => bt.Book)
            .Include(bt => bt.Member)
            .Where(bt =>
                bt.Book.BookName.ToLower().Contains(search) ||
                bt.Member.MemberId.ToString().ToLower().Contains(search))
            .ToListAsync();
    }
}
