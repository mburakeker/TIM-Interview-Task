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
        { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<BookTransaction> BookTransactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedConfigurations.ConfigureGenFu();
            var books = A.ListOf<Book>(200);
            var members = A.ListOf<Member>(20);
            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.Entity<Member>().HasData(members);
            //modelBuilder.Entity<BookTransaction>()
            //    .HasData(SeedConfigurations.CreateBookTransactionsWithRelations(books, members));
        }
    }
}