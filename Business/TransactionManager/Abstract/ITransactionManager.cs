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
        Task CreateBookTransaction(BookTransaction transaction);
        Task<List<BookTransaction>> GetBookTransactions();
    }
}
