using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.TransactionManager.Concrete;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace UnitTests.Business
{
    [TestFixture]
    class TransactionManagerTests
    {

        [Test]
        public void TransactionManager_SuggestReturnDate_Works_Ok_With_The_Childrens_Day()
        {
            var mockedLogger = new Mock<ILogger<TransactionManager>>();
            var transactionManager = new TransactionManager(mockedLogger.Object, null);
            var thirtyDaysBeforeChildrensDay = new DateTime(2021,03,24);
            var expected = new DateTime(2021,04,26);
            var suggestedDateDto = transactionManager.SuggestReturnDate(thirtyDaysBeforeChildrensDay,30);
            Assert.AreEqual(expected, suggestedDateDto.ReturnDate);
        }
    }
}
