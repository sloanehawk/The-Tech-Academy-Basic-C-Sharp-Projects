using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Drill25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string num = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\myProjects\numbers.txt", num);

            string readText = File.ReadAllText(@"C:\Users\Student\myProjects\numbers.txt");
            Console.WriteLine(readText);
            Console.ReadLine();

        }
    }
}
