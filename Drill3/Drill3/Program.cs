using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from the user, multiplies it by 50, and prints the result to the console.
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int result1 = num1 * 50;
            Console.WriteLine("Your number times 50 equals " + result1);

            //Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result2 = num2 + 25;
            Console.WriteLine("Your number plus 25 equals " + result2);

            //Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Enter a number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            float result3 = num3 / 12.5f;
            Console.WriteLine("Your number divided by 12.5 equals " + result3);

            //Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
            Console.WriteLine("Enter a number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool over50 = num4 > 50;
            Console.WriteLine(over50);

            //Takes an input from the user, divides it by 7, and prints the remainder to the console
            Console.WriteLine("Enter a number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int result5 = num5 % 7;
            Console.WriteLine("Your number divided by 7 has remainder " + result5);
            Console.ReadLine();

        }
    }
}
