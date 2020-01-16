using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill15
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
            MathOperation operation = new MathOperation();

            //3. Call the method in the class, passing in two numbers.
            operation.TimesTwo(2, 3);


            //4. Call the method in the class, specifying the parameters by name.
            operation.TimesTwo(int1: 4, int2: 7);


            Console.ReadLine();

        }
    }
}
