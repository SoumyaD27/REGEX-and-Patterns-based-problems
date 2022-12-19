using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PinCodeUC
{
    public class Pattern
    {
        public static string ZIPCODE = "^[0-9]{6}$" ;
        public bool Validate_ZipCode(string ZipCode)
        {
            return Regex.IsMatch(ZipCode, ZIPCODE);
        }
        public static string ZIPCODE1 = "^[0-9]{3} [0-9]{3}$";
        public bool ValidateZipCode(string zipCode)
        {
            return Regex.IsMatch(zipCode, ZIPCODE1);
        }
    }
}
