using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool isQualified = (age > 15 && DUI == false && tickets <= 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
            Console.ReadLine();

        }
    }
}
