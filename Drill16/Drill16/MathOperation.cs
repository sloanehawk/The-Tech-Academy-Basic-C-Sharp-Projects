using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill16
{
    public class MathOperation
    {
        //1. Create a class. In that class, 
        //create a void method that outputs an integer. 
        //Have the method divide the data passed to it by 2.
        public void DivideByTwo(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine(result);
        }


        //4. Create a method with output parameters.
        //5. Overload a method.
        public int DivideByTwo(int num2, int num3, out int result2)
        {
            int result1 = num2 / 2;
            result2 = num3 / 2;
            return result1;
        }

    }
}
