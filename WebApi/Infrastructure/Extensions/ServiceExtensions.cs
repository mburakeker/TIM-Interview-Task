using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Business.Dto;
using DataAccess.EntityFramework;
using Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddMapster(this IServiceCollection services)
        {
            TypeAdapterConfig.GlobalSettings.Default.NameMatchingStrategy(NameMatchingStrategy.Flexible);

            TypeAdapterConfig<BookTransaction, GetBookTransactionDto>
                .NewConfig()
                .Map(dest=>dest.BookName,src=>src.Book.BookName)
                .Map(dest=>dest.MemberName,src=>$"{src.Member.FirstName} {src.Member.LastName}");
            return services;
        }
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
