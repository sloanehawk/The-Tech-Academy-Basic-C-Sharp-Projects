using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill20
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.Id = 207;
            employee2.Id = 208;

            bool employeesEqual = employee1 == employee2;
            Console.WriteLine("Employee 1 and Employee 2 have the same ID: " + employeesEqual);

            Console.ReadLine();



        }
    }
}
