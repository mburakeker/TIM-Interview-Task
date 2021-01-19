using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dto;
using Business.ReportManager.Abstract;
using Mapster;
using Microsoft.Extensions.Logging;
using WebApi.Infrastructure.Response;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<ReportController> _logger;
        private readonly IReportManager _reportManager;
        public ReportController(ILogger<ReportController> logger, IReportManager reportManager)
        {
            _logger = logger;
            _reportManager = reportManager;
        }
        // GET: api/<ReportController>
        [HttpGet]
        public async Task<Response<BookTransactionDailyReportDto>> GetSuggestedReturnDate()
        {
            var response = new Response<BookTransactionDailyReportDto>();
            try
            {
                response.DataList = await _reportManager.GetDailyReport(7);
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }
    }
}
