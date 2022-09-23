using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //One dimensional array of strings;
            //Ask user to select an index of the array and then display the string at that index on the screen

            string[] stringArray = new string[6];
            stringArray[0] = "You will have a pretty good day today, not gonna lie.";
            stringArray[1] = "Your day will be terrible. I'd stay inside if I were you.";
            stringArray[2] = "I'd save my money for a rainy day. Something might happen soon.";
            stringArray[3] = "Spend some time with your loved ones, and eat more veggies!";
            stringArray[4] = "Do you really believe this junk?";
            stringArray[5] = "You'll be surprised at how people will wave at you if you wave at them.";

            Console.WriteLine("Choose a number from 0 to 5 and I will tell you your fortune!");
            int index = Convert.ToInt32(Console.ReadLine());


            //WHILE the index is not in the specified range, the Console will print out a statement to redo the task again
            while (index > 5 || index < 0)
            {
                Console.WriteLine("You didn't seem to be following diretions... Please choose a number between 0 and 6.");
                index = Convert.ToInt32(Console.ReadLine());
            }

            //only when the user inputs between 0-5 will the console output the fortune
            Console.WriteLine(stringArray[index]);


            ////////////////////////////////////////

            //One dimensional array of integers;
            //Ask user to select an index of the array and then display the integer at that index on the screen

            int[] intArray = { 61, 39, 47, 9, 25, 72, 0, 33, 49, 88, 13 };

            Console.WriteLine("Choose an index between 0 and 10 and I will show you a random number between 1 to 100!");
            int numIndex = Convert.ToInt32(Console.ReadLine());

            //while the inputted number is more than 10 or less than 0, console will print for user to follow directions and try again.
           
            while (numIndex > 10 || numIndex < 0)
            {
                Console.WriteLine("You didn't seem to be following directions... Please choose a number between 0 and 10.");
                numIndex = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(intArray[numIndex]);


            /////////////////////////////////////

            //Create a list of strings
            //Ask user to select an index of the list and ten display the content at index on screen

            List<string> stringList = new List<string>();
            stringList.Add("\"Hello there,\" the woman said.");
            stringList.Add("\"Howdy,\" said the man.");
            stringList.Add("\"How do you do?\" the masked gentlemen questioned.");
            stringList.Add("\"Where do you hail from?\" the portly dame asked joyously.");
            stringList.Add("\"Nice to meet you,\" the child squeaked out.");
            stringList.Add("\"Are you enjoying this?\" the programmer pondered.");

            Console.WriteLine("Enter a number from 0 - 5 and you will be greeted by one of our guests.");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            
            while (stringIndex > 5 || stringIndex < 0)
            {
                Console.WriteLine("Not following directions? Please choose a number between 0 and 5.");
                stringIndex = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(stringList[stringIndex]);
            Console.ReadLine();

        }
    }
}
