using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Utility;
namespace UnitTests.Utility
{
    [TestFixture]
    internal class UtilsTests
    {
        [Test]
        public void Utils_Encrypted_String_Can_Be_Decrypted([Values("p@ssW0rd!","şöğüıæ","Burak_Eker__")] string stringToEncrypt)
        {
            var encrypted = Utils.EncryptTripleDes(stringToEncrypt);
            Assert.AreEqual(stringToEncrypt, Utils.DecryptTripleDes(encrypted));
        }

        [Test]
        public void Utils_ConvertFullNameToUsername_Is_As_Expected()
        {
            Assert.AreEqual("mehmetburakeker",Utils.ConvertFullNameToUsername("Mehmet Burak","Eker"));
            Assert.AreEqual("9kkr", Utils.ConvertFullNameToUsername("9. Çğk"," Şükrü"));
        }
        [Test]
        [Repeat(25)]
        public void Utils_GenerateIsbnId_Can_Generate_13_Digits_Id()
        {
            Assert.AreEqual(13,Utils.GenerateIsbnId().Length);
        }
    }
}
