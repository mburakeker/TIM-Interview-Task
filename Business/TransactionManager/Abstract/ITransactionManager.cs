using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dto;

namespace Business.TransactionManager.Abstract
{
    public interface ITransactionManager
    {
        public ReturnDateDto SuggestReturnDate(DateTime date, int days);
    }
}
