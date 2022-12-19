using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Pattern
    {
        public static string firstName = "^[A-Z][a-z]{5}$";
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, firstName);
        }
        public static string lastName = "^[A-Z]$";
        public bool validatelasttName(string LastName)
        {
            return Regex.IsMatch(LastName, lastName);
        }
        public static string EmailId = "^[a-z]{7}[0-9]{3}[@][a-z]{5}[.][a-z]{3}$";
        public bool validateEmailAddres(string emailId)
        {
            return Regex.IsMatch(emailId, EmailId);
        }
        public static string phoneNumber = "^[+][0-9]{2}[0-9]{10}$";
        public bool validatePhoneNumber(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, phoneNumber);
        }
        public static string password = "^[A-Z][a-z]{8}[0-9][@]$";
        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, password);
        }
    }
}
