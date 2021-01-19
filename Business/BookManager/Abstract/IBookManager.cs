using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.BookManager.Abstract
{
    public interface IBookManager
    {
        Task<List<Book>> GetBooks();
        Task<List<Book>> GetBooksByText(string searchText);
        Task CreateBook(Book book);
    }
}
