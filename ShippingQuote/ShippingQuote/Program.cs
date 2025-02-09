using System;

namespace ShippingQuote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //To get the package weight
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            //To get the package dimensions
            Console.WriteLine("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            //To get the dimensions total
            int total = width + height + length;
            if(total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            int productMultiple = width * height * length;
            decimal quote = Math.Round((productMultiple * weight) / 100m, 2);

            Console.WriteLine("Your estimated total for shipping this package is: "+quote);
            Console.WriteLine("Thank you!");



        }
    }
}
