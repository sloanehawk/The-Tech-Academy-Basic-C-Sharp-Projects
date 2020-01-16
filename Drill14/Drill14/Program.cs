using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill14
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
            MathOperation operation = new MathOperation();

            //3. Ask the user to input two numbers, one at a time. 
            //Let them know they need not enter anything for the second number.
            Console.WriteLine("Enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            
            //4. Call the method in the class, passing in the one or two numbers entered.
            // try catch block to see if user enters a second number
            Console.WriteLine("Enter a second number (optional).");
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = operation.Add(num1, num2);
                Console.WriteLine("Result: " + result);
            }
            //if a second number is not entered, the catch block will be executed
            catch (Exception)
            {
                int result = operation.Add(num1);
                Console.WriteLine("Result: " + result);
            }

            
            Console.ReadLine();


        }
    }
}
