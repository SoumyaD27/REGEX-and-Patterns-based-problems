using System;
namespace EmailUC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter the Email ID: ");        //Try with abc.xyz@bridgelabz.co.in
            string email = Console.ReadLine();
            bool emailId = pattern.Validate_ZipCode(email);
            if(emailId)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Not Matching");
            }
        }
    }
}