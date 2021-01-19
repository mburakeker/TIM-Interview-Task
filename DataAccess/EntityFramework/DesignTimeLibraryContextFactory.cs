using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataAccess.EntityFramework
{
    internal class DesignTimeLibraryContextFactory : IDesignTimeDbContextFactory<LibraryContext>
    {
        private readonly IConfiguration _configuration;
        public DesignTimeLibraryContextFactory()
        {
            
        }
        public LibraryContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LibraryContext>();
            const string connectionString = @"Server=localhost;Database=Library;User ID=sa;Password=Sa_password!;";
            builder.UseSqlServer(connectionString);
            Console.WriteLine($"Running DesignTime DB context. ({connectionString})");
            return new LibraryContext(builder.Options);
        }
    }
}
