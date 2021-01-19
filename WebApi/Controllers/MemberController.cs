using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.MemberManager.Abstract;
using Entities;
using Mapster;
using Microsoft.Extensions.Logging;
using Serilog;
using WebApi.Infrastructure.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly ILogger<MemberController> _logger;
        private readonly IMemberManager _memberManager;
        public MemberController(ILogger<MemberController> logger, IMemberManager memberManager)
        {
            _logger = logger;
            _memberManager = memberManager;
        }
        // GET: api/<MemberController>
        [HttpGet]
        public async Task<Response<Member>> Get()
        {
            var response = new Response<Member>();
            try
            {
                response.DataList = await _memberManager.GetMembers();
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }

        // POST api/<MemberController>
        [HttpPost]
        public async Task<Response<Member>> Post([FromBody] Member member)
        {
            var response = new Response<Member>();
            try
            {
                await _memberManager.SaveMember(member);
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }

        // PUT api/<MemberController>/5
        [HttpPut]
        public async Task<Response<Member>> Put([FromBody] Member member)
        {
            var response = new Response<Member>();
            try
            {
                await _memberManager.UpdateMember(member);
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }

        // DELETE api/<MemberController>/5
        [HttpDelete("{id}")]
        public async Task<Response<Member>> Delete(int id)
        {
            var response = new Response<Member>();
            try
            {
                await _memberManager.DeleteMember(id);
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(ex.Adapt<ApiException>());
            }
            return response;
        }
    }
}
