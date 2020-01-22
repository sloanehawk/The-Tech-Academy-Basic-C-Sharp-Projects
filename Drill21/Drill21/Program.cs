using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill21
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "a", "b", "c", "d" };

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 5, 10, 15, 20 };

            //create a loop that prints all of the Things to the console
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            
            foreach(int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            
            Console.ReadLine();
            
        }
    }
}
