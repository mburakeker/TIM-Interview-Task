using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.EntityFrameworkCore;
using GenFu;
namespace DataAccess.EntityFramework
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedConfigurations.ConfigureGenFu();
            modelBuilder.Entity<Book>().HasData(A.ListOf<Book>(200));
            modelBuilder.Entity<Member>().HasData(A.ListOf<Member>(20));
        }
    }
}