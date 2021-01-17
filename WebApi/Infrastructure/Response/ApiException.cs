using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Infrastructure.Response
{
    public class ApiException
    {
        public string Message { get; set; }
        public string Detail { get; set; }
    }
}
