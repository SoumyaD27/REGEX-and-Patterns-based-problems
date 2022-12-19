using  System;
namespace PinCodeUC
{
    class Program
    {               //UseCase 1, 2, 3, 4 can be performed here. 
        public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            { 
                case 1:
                Console.WriteLine("Enter the ZipCode");                //Try with 400088, A400088, 400088B
                string ZipCode = Console.ReadLine();
                bool zip = pattern.Validate_ZipCode(ZipCode);
                if (zip)
                {
                    Console.WriteLine("Correct, its a match.");
                }
                else
                {
                    Console.WriteLine("Not matching");
                }
                break;
            case 2:
                Console.WriteLine("Enter the ZipCode");                //Try with 400 088
                string zipCode = Console.ReadLine();
                bool zip1 = pattern.ValidateZipCode(zipCode);
                if (zip1)
                {
                    Console.WriteLine("Correct, its a match.");
                }
                else
                {
                    Console.WriteLine("Not matching");
                }
                break;
            }
        }
    }
}