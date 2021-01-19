using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.BookManager.Abstract;
using Business.Dto;
using DataAccess.EntityFramework;
using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Business.BookManager.Concrete
{
    public class BookManager: IBookManager
    {
        private readonly ILogger<BookManager> _logger;
        private readonly LibraryContext _context;
        public BookManager(LibraryContext context, ILogger<BookManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Book>> GetBooks() => await _context.Books.Take(50).ToListAsync();

        public async Task<List<Book>> GetBooksByText(string searchText) => await _context.Books.FromSqlRaw(
            "Select * from Books where IsbnId LIKE @SearchText OR Author LIKE @SearchText OR BookName LIKE @SearchText",
            new SqlParameter("SearchText",$"%{searchText}%")).ToListAsync();

        internal async Task<Book> GetBookById(string id) => await _context.Books.SingleOrDefaultAsync(book => book.IsbnId == id);

        public async Task CreateBook(Book book)
        {
            if (book == null)
            {
                _logger.LogError("CreateBook book is not valid!");
                throw new Exception("Book you are trying to save is not valid!");
            }
            if (book.IsbnId == null)
            {
                _logger.LogError("CreateBook book isbn id is not valid!");
                throw new Exception("Isbn Id not found!");
            }
            if (book.Count <= 0)
            {
                _logger.LogError("CreateBook book count is lower than 1");
                throw new Exception("Book count cant be lower than 1!");
            }
            var bookEntity = await GetBookById(book.IsbnId);
            if (bookEntity == null)
            {
                _context.Books.Add(book);
            }
            else
            {
                bookEntity.Count += book.Count;
            }
            await _context.SaveChangesAsync();
        } 
 
    }
}
