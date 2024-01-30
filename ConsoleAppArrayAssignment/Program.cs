using System;
using System.Collections.Generic;


namespace ConsoleAppArrayAssignment

{
    class Program
    {
        // CONSOLE APP ARRAY ASSIGNMENT
        ///Create a console app that does/contains the following:
        //Create a list of strings.Ask the user to select an index of the list and then display the content at that index on the screen.
        //Add in a message that displays when the user selects an index that doesn’t exist.

        public static void Main()
        {//Create a one-dimensional Array of strings.Ask the user to select an index of the Array and then display the string at that index on the screen.
            string [] cheeses = { "American", "Brie", "Cheddar","Mozzarella" };
            Console.WriteLine("Please enter a number between 0-3 to see what your cheese surprise will be!");
            //this asks the user to select numbers via index position in the array, 0 thru 3. 
            int answer = int.Parse(Console.ReadLine());
            {
                if (answer <= 3)

                    Console.WriteLine("Hooray, gouda for you, your cheese prize is " + cheeses[answer] + "!!!!!");
                else
                    Console.WriteLine("Drat. No cheese for thee. Next time, do please enter a number between 0 and 3.");

            }

            //Create a one - dimensional Array of integers.Ask the user to select an index of
            //the Array and then display the integer at that index on the screen.
            int[] a = { 7, 43, 1, 12, 19 };
            //this is the array of integers.

            Console.WriteLine("Please select a number between 0-4.");
            //this asks the user to select numbers via index position in the array, 0 thru 4. 
            int input = int.Parse(Console.ReadLine());
            //this takes the user input and converts it to a variable integer.
            //this formula of "a[input] takes the array and index position and prints it to the console.
            //Add in a message that displays when the user selects an index that doesn’t exist.
            {
                if (input <= 4)

                    Console.WriteLine("Value is: " + a[input]);
                else
                    Console.WriteLine("Something went wrong! The number you picked is outside of the range. Next time, please enter a number between 0 and 4.");

            }

        }
    }
}