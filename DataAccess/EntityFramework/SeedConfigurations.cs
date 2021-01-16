using System;
using Entities;
using GenFu;
using Utility;
namespace DataAccess.EntityFramework
{
    public static class SeedConfigurations
    {
        public static void ConfigureGenFu()
        {
            var index = 1;
            A.Configure<Book>()
                .Fill(b => b.BookId, () => index++)
                .Fill(b => b.Author).AsMusicArtistName()
                .Fill(b => b.BookName).AsMusicGenreName()
                .Fill(b=>b.IsbnId, Utils.GenerateIsbnId);
            index = 1;
            A.Configure<Member>()
                .Fill(m => m.PhoneNumber).AsPhoneNumber()
                .Fill(c => c.Username, m => Utils.ConvertFullNameToUsername(m.FirstName,m.LastName))
                .Fill(m => m.EmailAddress, m => $"{m.Username}@libra.ry")
                .Fill(m => m.HomeAddress).AsAddress()
                .Fill(m => m.BirthDate).AsPastDate()
                .Fill(m => m.RegistrationDate, Utils.GenerateRegistrationDate)
                .Fill(m=>m.MemberId,()=>index++);
        }
    }
}
