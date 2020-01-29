using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill28
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your age: ");
            
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0)
                {
                    throw new AgeException("You must enter a non zero integer.");
                }
                if (age<0)
                {
                    throw new AgeException("You must enter a positive integer.");
                }
                DateTime dateBorn = DateTime.Now.AddYears(-age); //Subtract the user's age from the current year
                int yearBorn = dateBorn.Year;
                Console.WriteLine("You were born in " + yearBorn);
                
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("You entered an invalid age.");
            }
            
            Console.ReadLine();
        }
    }
}
