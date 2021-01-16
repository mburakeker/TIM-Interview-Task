using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
