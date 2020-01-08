using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill7
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop
            Console.WriteLine("While loop: ");
            Console.ReadLine();
            int a = 0;

            while (a < 0) 
            {
                
                Console.WriteLine("The value of a is {0}", a); //display the value of a 
                a++; // add 1 to a 
                Console.ReadLine();
              
                
                
            }

            //do while loop
            Console.WriteLine("Do while loop: ");
            Console.ReadLine();
            int b = 0;

            // do loop will always execute at least once
            do
            {
               
                Console.WriteLine("The value of b is {0}", b); //display the value of b
                b++; //add 1 to b 

                Console.ReadLine();
                
            } while (b < 0);

            Console.ReadLine();

        }
    }
}
