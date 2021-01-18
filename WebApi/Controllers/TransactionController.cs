﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dto;
using Business.TransactionManager.Abstract;
using Entities;
using Mapster;
using Microsoft.Extensions.Logging;
using WebApi.Infrastructure.Response;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ILogger<TransactionController> _logger;
        private readonly ITransactionManager _transactionManager;
        public TransactionController(ILogger<TransactionController> logger, ITransactionManager transactionManager)
        {
            _logger = logger;
            _transactionManager = transactionManager;
        }
        // GET: api/<TransactionController>
        [HttpGet]
        public async Task<Response<BookTransaction>> Get()
        {
            var response = new Response<BookTransaction>();
            try
            {
                response.DataList = await _transactionManager.GetBookTransactions();
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }
        // GET: api/<TransactionController>/GetSuggestedReturnDate
        [HttpGet("GetSuggestedReturnDate")]
        public Response<ReturnDateDto> GetSuggestedReturnDate()
        {
            var response = new Response<ReturnDateDto>();
            try
            {
                response.Data = _transactionManager.SuggestReturnDate(DateTime.Today,30);
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }
        // POST: api/<TransactionController>
        [HttpPost]
        public async Task<Response<ReturnDateDto>> CreateBookTransaction([FromBody] BookTransaction transaction)
        {
            var response = new Response<ReturnDateDto>();
            try
            {
                await _transactionManager.CreateBookTransaction(transaction);
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }

    }
}
