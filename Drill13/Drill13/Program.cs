using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill13
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, 
            //instantiate the class and call the one method, passing in an integer.
            //Display the result to the screen.


            MathOperation m = new MathOperation();
            int a = 5;

            int result1 = m.Multiply(a);
            Console.WriteLine("Result 1: " + result1);

            //In the Main() method of the console app, 
            //instantiate the class and call the second method, passing in a decimal.
            //Display the result to the screen.
            decimal b = 4.5m;

            int result2 = m.Multiply(b);
            Console.WriteLine("Result 2: " + result2);

            //6. In the Main() method of the console app, 
            //instantiate the class and call the third method, 
            //passing in a string that equates to an integer. Display the result to the screen.
            string c = "7";

            int result3 = m.Multiply(c);
            Console.WriteLine("Result 3: " + result3);



            Console.ReadLine();
        }
    }
}
