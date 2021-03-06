﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill22
{
    class Program
    {
        //1. Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            //2. Prompt the user to enter the current day of the week.
            Console.WriteLine("Enter the current day of the week: ");

            //4. Wrap the statement in a try/catch block and have it print 
            //"Please enter an actual day of the week." to the console if an error occurs.
            //3. Assign the value to a variable of that enum data type you just created.


            try
            {
                DaysOfTheWeek dayEntered = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
           
            
        }

    }
}
