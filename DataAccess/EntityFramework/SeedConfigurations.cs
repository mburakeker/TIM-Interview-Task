using System;
using System.Collections.Generic;
using Entities;
using GenFu;
using Utility;
namespace DataAccess.EntityFramework
{
    public static class SeedConfigurations
    {
        public static void ConfigureGenFu()
        {
            A.Configure<Book>()
                .Fill(b => b.Author).AsMusicArtistName()
                .Fill(b => b.BookName).AsMusicGenreName()
                .Fill(b=>b.IsbnId, Utils.GenerateIsbnId)
                .Fill(b=>b.Count).WithinRange(0,5);
            var index = 1;
            A.Configure<Member>()
                .Fill(m => m.PhoneNumber).AsPhoneNumber()
                .Fill(m => m.EmailAddress, m => $"{Utils.ConvertFullNameToUsername(m.FirstName, m.LastName)}@libra.ry")
                .Fill(m => m.HomeAddress).AsAddress()
                .Fill(m => m.BirthDate).AsPastDate()
                .Fill(m => m.RegistrationDate, Utils.GenerateRegistrationDate)
                .Fill(m => m.MemberId,()=>index++);
        }
        public static List<BookTransaction> CreateBookTransactionsWithRelations(List<Book> books, List<Member> members)
        {
            var smallestCount = (books.Count > members.Count) ? members.Count : books.Count;
            var bookTransactions = A.ListOf<BookTransaction>(smallestCount);
            for (var i=0; i< smallestCount; i++)
            {
                bookTransactions[i].MemberId = members[i].MemberId;
                bookTransactions[i].Member = null;
                bookTransactions[i].IsbnId = books[i].IsbnId;
                bookTransactions[i].Book = null;
            }
            return bookTransactions;
        }
    }
}
