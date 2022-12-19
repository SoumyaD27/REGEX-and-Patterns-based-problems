using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailUC
{
    public class Pattern
    {
        public static string Email = "^[a-z]{3}[.][a-z]{3}[@][a-z]{10}[.][a-z]{2}[.][a-z]{2}$";
        public bool Validate_ZipCode(string email)
        {
            return Regex.IsMatch(email, Email);
        }
    }
}
