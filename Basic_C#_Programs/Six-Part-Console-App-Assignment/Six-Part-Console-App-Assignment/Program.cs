using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            ////// CONSOLE APP ASSIGNMENT PART ONE //////

            // 1. One dimensional array of strings //

            string[] stringArray = { "You know what has four legs? ", "You know what has two ears? ", "You know what has two eyes? ", "You know what has a brain smaller than a humans? " };

            // 2. Ask the user to input some text //
            Console.WriteLine("Please enter a four legged animal:");
            string input = Console.ReadLine();


            // 3. Loop that iterates through each string in array and adds user text input
            //    Loop will update each array element by appending the user's text //

            for (int i = 0; i < stringArray.Length; i++)
            {
                string output = stringArray[i] + input;

                // 4. Create a second loop that prints off each string in the array one at a time //
                foreach (int q in stringArray[i])
                {
                    Console.WriteLine(output);
                    break;
                }

            }
            Console.ReadLine();



            ////// CONSOLE APP ASSIGNMENT PART TWO //////

            // 1 + 2. Add an infinite loop and save your code //

            while (true)
            {
                Console.WriteLine("Hello there!");
                // 3. Fix the infinite loop so that it will execute properly //
                // The infinite loop was fixed by adding a break; to the while loop //
                break;
            }
            Console.ReadLine();



            ////// CONSOLE APP ASSIGNMENT PART THREE //////

            // 1. A loop where the comparison that's used to determine whether to continue iterating the loop is a "<" operator;
            // 2. Save and execute code //

            int[] numArray = { 1, 5, 10, 15, 25, 40 };

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            Console.ReadLine();

            // 3. Add another loop where the comparison that's used to determine whether to continue is a "<=" operator //

            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();





            ////// CONSOLE APP ASSIGNMENT PART FOUR //////
            ///

            // 1. A list of strings where each item in the list is unique //

            List<string> names = new List<string>() { "Kevin", "Kenny", "Kelley", "Shosha", "Shayne", "Abe", "Calvin", "Gigi", "Howard" };

            // 2. Ask the user to input text to search for in the list //

            Console.WriteLine("Please enter a name to see if it matches with any names on my list.");
            //will acquire input from user and convert to lower case
            var userGuess = Console.ReadLine();
            //listIndex will just count how many element indexes are in the list
            int listIndex = names.Count();


            // 3. A loop that iterates through the list and displays the index of the list item that contains matching text on the screen //

            bool found = false;

            for (int i = 0; i < listIndex; i++)
            {
                if (names[i] == userGuess)
                {
                    Console.WriteLine("The name you have chosen is at index " + i);
                    found = true;

                    // 5. Added code to stop loop after matching text has been found
                    break;
                }

            }

            // 4. Add code to check if user is on the list, and if it isn't, then tells user the name is not on the list
            if (!found)
            {
                Console.WriteLine("Sorry, there is no name in this list by that name.");
            }



            ////// CONSOLE APP ASSIGNMENT PART FIVE //////
            ///

            // 1. A list of strings that has at least two identical  strings in the list. Ask the user to select text to search for in the list

            List<string> classes = new List<string>() { "music", "art", "social studies", "math", "music", "woodworking", "home economics", "history", "psychology" };
            Console.WriteLine("Please enter a school subject and we'll see if there are any duplicate courses (ex: art, history, music, etc)");
            string classGuess = Console.ReadLine();
            int classIndex = classes.Count();

            bool classFound = false;

            // 2. Create a loop that iterates through the list and then displays the indices of the items  matching the user-selected text.
            // Ensure to remove any break statements  that may prevent your code  from returning multiple matches

            for (int i = 0; i < classIndex; i++)
            {
                if (classes.Contains(classGuess))
                {
                    if (classes[i] == classGuess)
                    {
                        Console.WriteLine("This class will be at index " + i);
                        classFound = true;
                    }
                }

            }

            // 3. Add code  to the loop to check  if the user put in text that is not on the list, and if they did, tells the user their input is not on the list

            if (!classFound)
            {
                Console.WriteLine("Sorry, there are no classes by that name in our curriculum quite yet.");
            }


            Console.ReadLine();



            ////// CONSOLE APP ASSIGNMENT PART SIX //////
            ///

            // 1. Create a list of strings  that has at least two identical strings in it

            List<string> pets = new List<string>() { "cat", "dog", "parrot", "fish", "tarantula", "bearded dragon", "fish" };
            List<string> comparePets = new List<string>();

            // 2. Create a foreach loop that evaluates each item on the list, and displays a message showing the string and whether or not it has already appeard in the list

            foreach (string pet in pets)
            {
                //compares the empty (so far) string list to the pets list
                if (comparePets.Contains(pet))
                {
                    Console.WriteLine("This pet is very common. Someone else already has a " + pet + " for a pet");
                }
                //If there are no duplicates, it will be added to comparePets list
                else
                {
                    comparePets.Add(pet);
                    Console.WriteLine("Someone has a " + pet + " for a pet.");
                }
            }

            Console.ReadLine();

        }
    }
}
