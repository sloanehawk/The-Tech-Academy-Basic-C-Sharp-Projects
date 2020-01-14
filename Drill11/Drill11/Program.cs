using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a list of integers. Ask the user for a number to divide each number in the list by. 
            //Write a loop that takes each integer in the list, divides it by the number the user entered, 
            //and displays the result to the screen.
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };
            Console.WriteLine("Enter a number to divide each number in the list by.");
            
            try
            {
                foreach (int number in numbers)
                {
                    int numInput = Convert.ToInt32(Console.ReadLine());
                    int result = number / numInput;
                    Console.WriteLine(number + " divided by " + numInput + " equals " + result);

                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("The program has emerged from the try/catch block.");
            Console.ReadLine();
        }
    }
}
