using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddDbService(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            if (connectionString == null)
            {
                throw new Exception("DB_CONNECTION_STRING variable hasn't found in env!");
            }
            services.AddDbContext<LibraryContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
