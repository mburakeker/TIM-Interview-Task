using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dto;
using Entities;

namespace Business.TransactionManager.Abstract
{
    public interface ITransactionManager
    {
        ReturnDateDto SuggestReturnDate(DateTime date, int days);
        Task<ReturnPriceDto> GetReturnPriceByTransactionId(int transactionId);
        Task CreateBookTransaction(BookTransaction transaction);
        Task ReturnBook(int transactionId);
        Task<List<GetBookTransactionDto>> GetBookTransactions();
        Task<List<BookTransaction>> SearchBookTransactions(string search);
    }
}
