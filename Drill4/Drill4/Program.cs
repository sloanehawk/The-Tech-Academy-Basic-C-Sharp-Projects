using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int hrlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hrsWorked1 = Convert.ToInt32(Console.ReadLine());
            int salary1 = hrlyRate1 * hrsWorked1;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hrlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hrsWorked2 = Convert.ToInt32(Console.ReadLine());
            int salary2 = hrlyRate2 * hrsWorked2;

            Console.WriteLine("Weekly salary of Person 1: " + salary1);
            Console.WriteLine("Weekly salary of Person 2: " + salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool makesMore = salary1 > salary2;
            Console.WriteLine(makesMore);
            Console.ReadLine();
        }
    }
}
