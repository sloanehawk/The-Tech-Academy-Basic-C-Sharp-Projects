using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a one-dimensional Array of strings. 
            //Ask the user to select an index of the Array and then display the string at that index on the screen.

            string[] stringArray = { "pickles", "cheese", "eggs", "bread", "apples" };
            Console.WriteLine("Enter an index(0-4) of the array to display.");
            int arrayIndex = Convert.ToInt32(Console.ReadLine());

            //display a message if the index does not exist
            try
            {
                Console.WriteLine(stringArray[arrayIndex]);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("The index you entered does not exist.");
            }
            

            //2.Create a one-dimensional Array of integers.
            //Ask the user to select an index of the Array and then display the integer at that index on the screen.

            int[] intArray = { 3, 6, 9, 12, 15 };
            Console.WriteLine("Enter an index(0-4) of the array to display.");
            int arrayIndex2 = Convert.ToInt32(Console.ReadLine());

            //display a message if the index does not exist
            try
            {
                Console.WriteLine(intArray[arrayIndex2]);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("The index you entered does not exist.");
            }

            //4. Create a List of strings. 
            //Ask the user to select an index of the List and then display the content at that index on the screen.
            List<string> stringList = new List<string>();
            stringList.Add("a");
            stringList.Add("b");
            stringList.Add("c");
            stringList.Add("d");
            stringList.Add("e");

            Console.WriteLine("Enter an index(0-4) of the list to display.");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(stringList[listIndex]);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("The index you entered does not exist.");
            }
            Console.ReadLine();


        }
    }
}
