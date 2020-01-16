using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill16
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, instantiate that class.
            MathOperation m = new MathOperation();

            //3. Have the user enter a number. Call the method on that number. 
            //Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine("Enter a number.");
            int numInput = Convert.ToInt32(Console.ReadLine());
            m.DivideByTwo(numInput);

            //call overloaded method
            int a = 9;
            int remainder = m.DivideByTwo(a);




            Console.ReadLine();



        }
    }
}
