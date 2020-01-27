using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill26
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Please enter a number: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            var then = now.AddHours(hours);
            Console.WriteLine("In " + hours + " hours, it will be " + then);
            Console.ReadLine();

        }
    }
}
