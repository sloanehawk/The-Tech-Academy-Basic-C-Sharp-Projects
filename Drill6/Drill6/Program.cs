using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight.");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width.");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height.");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length.");
            int length = Convert.ToInt32(Console.ReadLine());

            int sumDimensions = width + height + length;

            if (sumDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            decimal price = sumDimensions*weight / 100m;
            string priceString = price.ToString("0.00");


            Console.WriteLine("Your estimated total for shipping this package is : $" + priceString);
            Console.WriteLine("Thank you.");
            Console.ReadLine();
            








        }
    }
}
