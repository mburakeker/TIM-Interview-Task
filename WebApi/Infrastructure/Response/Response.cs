using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApi.Infrastructure.Response
{
    public class Response<T>:HttpResponseMessage where T : class
    {
        public T Data { get; set; }
        public List<T> DataList { get; set; }
        public List<ApiException> ErrorList { get; set; }

        public bool ErrorState => ErrorList.Count > 0;

        public bool RequestState => Data != null || DataList.Count > 0;
        public Task<List<T>> AsyncList { get; set; }
        public int EntityCount { get; set; }
        public Response()
        {
            ErrorList = new List<ApiException>();
            DataList = new List<T>();

        }
    }
}
