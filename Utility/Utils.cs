using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Utility
{
    public static class Utils
    {
        public static string ConvertFullNameToUsername(string firstName, string lastName)
        {
            const string regexPattern = @"\s+|[^a-zA-Z0-9]"; // \s means whitespace chars = [\r\n\t\f\v ],
                                                             // + means 1 or more chars
                                                            // | means OR,
                                                            // [^a-zA-Z] to exclude chars that are not a to Z (case insensitive)
            var trimmedUsername = Regex.Replace(firstName+lastName, regexPattern, "").ToLower();
            return trimmedUsername;
        }

        public static string GenerateIsbnId()
        {
            var generator = new Random();
            var digits = generator.Next(0, 999999).ToString("D6") + generator.Next(0, 9999999).ToString("D7");
            return digits;
        }
        public static DateTime GenerateRegistrationDate()
        {
            return DateTime.Now - TimeSpan.FromDays(new Random().Next(20, 1000));
        }

        private const string Hash = "placeputyourownstringkey";

        public static string EncryptTripleDes(string password)
        {
            var data = Encoding.UTF8.GetBytes(password);
            using var md5 = new MD5CryptoServiceProvider();
            var keys = md5.ComputeHash(Encoding.UTF8.GetBytes(Hash));
            using var tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            var transform = tripDes.CreateEncryptor();
            var results = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(results, 0, results.Length);
        }

        public static string DecryptTripleDes(string hashedValue)
        {
            var data = Convert.FromBase64String(hashedValue);
            using var md5 = new MD5CryptoServiceProvider();
            var keys = md5.ComputeHash(Encoding.UTF8.GetBytes(Hash));
            using var tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            var transform = tripDes.CreateDecryptor();
            var results = transform.TransformFinalBlock(data, 0, data.Length);
            return Encoding.UTF8.GetString(results);
        }
    }
}
