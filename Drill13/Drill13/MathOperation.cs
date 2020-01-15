using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill13
{
    public class MathOperation
    {
        //1. Create a class. In that class, create a method that will take in an integer,
        //do a math operation to it and then return the answer as an integer.
        public int Multiply(int num1)
        {
            int result = num1 * 2;
            return result;
        }

        //3. Add a second method to the class, with the same name, that will take in a decimal,
        //do a different math operation to it and then return the answer as an integer.
        public int Multiply(decimal dec1)
        {
            decimal result = dec1 * 10;
            int resultInt = Convert.ToInt32(result);
            return resultInt;
        }

        //5. Add a third method to the class, with the same name, that will take in a string, 
        //convert it to an integer if possible, do a different math operation to it 
        //and then return the answer as an integer.
        public int Multiply(string str1)
        {
            int result = Convert.ToInt32(str1);
            result = result + 2;
            return result;
        }
    }
}
