using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.BookManager.Abstract;
using Entities;
using Mapster;
using WebApi.Infrastructure.Response;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookManager _bookManager;
        public BookController(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }
        // GET: api/<BookController>
        [HttpGet]
        public async Task<Response<Book>> Get()
        {
            var response = new Response<Book>();
            try
            {
                response.DataList = await _bookManager.GetBooks();
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }

        // GET api/<BookController>/{search}
        [HttpGet("{search}")]
        public async Task<Response<Book>> Get(string search)
        {
            var response = new Response<Book>();
            try
            {
                response.DataList = await _bookManager.GetBooksByText(search);
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }
        // POST: api/<BookController>
        [HttpPost]
        public async Task<Response<Book>> CreateBook([FromBody] Book book)
        {
            var response = new Response<Book>();
            try
            {
                await _bookManager.CreateBook(book);
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }
    }
}
