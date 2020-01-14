using System;
using System.Collections.Generic;

namespace Drill10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a one-dimensional Array of strings. 
            string[] stringArray = new string[4];

            //Ask the user to input some text. 
            Console.WriteLine("Input text to add strings to the array.");

            //Create a loop that goes through each string in the Array, adding the user’s text to the string. 
            for (int i=0; i<stringArray.Length; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            //Then create a loop that prints off each string in the Array on a separate line.
            for (int j=0; j<stringArray.Length; j++)
            {
                Console.WriteLine(stringArray[j]);
            }

            //2. Create an infinite loop.
            //3. Fix the infinite loop so it will execute.
            //4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            for (int k=0; k<10; k++)
            {
                Console.WriteLine(k);
            }

            //5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            for (int l=0; l<=10; l++)
            {
                Console.WriteLine(l);
            }

            //6. Create a List of strings where each item in the list is unique. 
            List<string> letters = new List<string>() { "a", "b", "c", "d", "e" };

            //Ask the user to input text to search for in the List. 
            Console.WriteLine("Input a letter (a-e) to search for in the list of strings.");
            string letterInput = Console.ReadLine();

            //Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.
            //7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //8.Add code to that above loop that stops it from executing once a match has been found.
            if (letters.Contains(letterInput))
            {
                foreach (string letter in letters)
                {
                    if (letterInput == letter)
                    {
                        int letterIndex = letters.IndexOf(letterInput);
                        Console.WriteLine("The index of the letter you entered is " + letterIndex);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("You entered text that isn't in the List.");
            }

            //9.Create a List of strings that has at least two identical strings in the List. 
            List<string> pets = new List<string> { "dog", "fish", "cat", "dog", "bird", "cat", "fish" };

            //Ask the user to select text to search for in the List.
            Console.WriteLine("Enter one of the following to search for in the list of pets: dog, cat, bird, fish");
            string petInput = Console.ReadLine();

            //Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
            if (pets.Contains(petInput))
                {
                    for (int m = 0; m < pets.Count; m++)
                    {
                        if (pets[m] == petInput)
                        {
                            Console.WriteLine(petInput + " is in index " + m);
                        }
                    }
                }
            else
            {
                Console.WriteLine("The text you entered is not in the list.");
            }

            //10. Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //11. Create a List of strings that has at least two identical strings in the List. 
            List<string> cheeses = new List<string>() { "Gouda", "Goat", "Brie", "Cheddar", "Goat", "Swiss", "Brie" };

            //Create a foreach loop that evaluates each item in the list, 
            //and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> cheeseList = new List<string>(); // initalize a list to add each item to in the foreach loop

            foreach (string cheese in cheeses)
            {
                if (cheeseList.Contains(cheese))
                {
                    Console.WriteLine(cheese + " has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine(cheese + " has not already appeared in the list.");
                    cheeseList.Add(cheese); // add the cheese to the list
                }
            }



            Console.ReadLine();
        }
    }
}
