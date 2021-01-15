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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData( 
                new { Id=1,  BookName="american", Author = "readymade", IsbnId = "mlkshk", CurrentHolder = "street" },
                new { Id=2,  BookName= "whatever", Author = "fixie", IsbnId = "fixie", CurrentHolder = "haven't" },
                new { Id=3,  BookName= "Lo-fi", Author = "loko", IsbnId = "they", CurrentHolder = "occupy" },
                new { Id=4,  BookName= "raw", Author = "rights", IsbnId = "art", CurrentHolder = "part" },
                new { Id=5,  BookName= "apparel", Author = "richardson", IsbnId = "narwhal", CurrentHolder = "beer" },
                new { Id=6,  BookName= "Iphone", Author = "narwhal", IsbnId = "freegan", CurrentHolder = "kogi" },
                new { Id=7,  BookName= "company", Author = "pickled", IsbnId = "DIY", CurrentHolder = "Polaroid" },
                new { Id=8,  BookName= "Ethnic", Author = "keffiyeh", IsbnId = "trust", CurrentHolder = "shorts" },
                new { Id=9,  BookName= "vice", Author = "bicycle", IsbnId = "ethnic", CurrentHolder = "park" },
                new { Id=10, BookName= "post-ironic", Author = "Post-ironic", IsbnId = "Marfa", CurrentHolder = "pickled" }
            );
        }
    }
}