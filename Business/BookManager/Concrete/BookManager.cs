using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.BookManager.Abstract;
using DataAccess.EntityFramework;
using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Business.BookManager.Concrete
{
    public class BookManager: IBookManager
    {
        private readonly LibraryContext _context;
        public BookManager(LibraryContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetBooks() => await _context.Books.ToListAsync();

        public async Task<List<Book>> GetBooksByText(string searchText) => await _context.Books.FromSqlRaw(
            "Select * from Books where IsbnId LIKE @SearchText OR Author LIKE @SearchText OR BookName LIKE @SearchText",
            new SqlParameter("SearchText",searchText)).ToListAsync();

        public async Task<Book> GetBookById(string id) => await _context.Books.SingleAsync(book => book.IsbnId == id);


    }
}
