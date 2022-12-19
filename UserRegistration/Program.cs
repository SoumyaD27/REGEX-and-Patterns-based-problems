using System;
namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {    
            //All use case of user registrartion are in it from 1 to 8.
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.validateFirstName("Soumya"));
            Console.WriteLine(pattern.validatelasttName("D"));
            Console.WriteLine(pattern.validateEmailAddres("abcdefg589@gmail.com"));
            Console.WriteLine(pattern.validatePhoneNumber("+917857690564"));
            Console.WriteLine(pattern.validatePassword("Inkjkgthj7@"));
        }
    }
}