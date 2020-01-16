using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill14
{
    public class MathOperation
    {
        //1. Create a class. In that class, create a method that takes two integers as parameters.
        //Make one of them optional. Have the method do a math operation and return an integer result.

        public int Add(int num1, int num2 = 10)
        {
            int result = num1 + num2;
            return result;
        }
    }
}
