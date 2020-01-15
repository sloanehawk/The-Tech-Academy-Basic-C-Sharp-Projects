using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer.");
            int a = Convert.ToInt32(Console.ReadLine());

            MathOperation n = new MathOperation();

            int result1 = n.PlusTwo(a);
            Console.WriteLine("Your number plus two is " + result1);

            int result2 = n.TimesTwo(a);
            Console.WriteLine("Your number times two is " + result2);

            int result3 = n.DividedByTwo(a);
            Console.WriteLine("Your number divided by two is " + result3);
            Console.ReadLine();

        }
    }
}
