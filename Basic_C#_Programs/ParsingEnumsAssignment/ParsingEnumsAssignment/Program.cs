using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompts user to enter day of the week
            Console.WriteLine("Please write down the current day of the week:");

            bool isValid = false;

            //use method Enum.Parse

            while (!isValid)
            {
                try
                {
                    //sets user input to UserDay
                    string UserDay = Console.ReadLine();
                    //DaysOfTheWeek day = the enum DaysOfTheWeek is delegated to the day variable.
                    //(DaysOfTheWeek)Enum = we are establishing that the enunm that we are using is (DaysOfTheWeek)
                    //Enum.Parse(typeof(DaysOfTheWeek) = we are parsing through the list of enums and we are establishing that enums DaysOfTheWeek is the type that we are going through
                    //, UserDay); = We are somparing if the user inputted UserDay is equal to anything on the enum list
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), UserDay);
                    Console.WriteLine(day);
                    isValid = true;
                }

                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter a day of the week.");
                }


                Console.ReadLine();
            }
        }

      
        //created enum for Days of the Week
        public enum DaysOfTheWeek
        {
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
        }
    }
}
