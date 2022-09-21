using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Car Insurance Basic Approval");

            int age;
            bool DUI;
            int speedingTickets;
            
            //Asks age and converts answer to integer
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            ////Asks if DUI had been obtained in the past and converts to Boolean
            Console.WriteLine("Have you ever had a DUI? (\"Yes\" or \"No\")");
            DUI = Console.ReadLine() == "Yes";  //("Yes" == true;)

            ////Asks how many speeding tickets recieved and converts to integer
            Console.WriteLine("How many speeding tickets have you had in the past?");
            speedingTickets = Convert.ToInt32(Console.ReadLine());

            


            /////////////////////////////////
            bool qualifiedAge;
            bool qualifiedDUI;
            bool qualifiedTickets;
            bool qualifiedForInsurance;

            //Determines if person is of qualified age, DUI status, and amount of speeding tickets they've accrued
            qualifiedAge = age > 15;
            qualifiedDUI = DUI == false;
            qualifiedTickets = speedingTickets <= 3;

         
            if (qualifiedAge && qualifiedDUI && qualifiedTickets)
            {
                Console.WriteLine("You are qualified for insurance!");
            }
            else
            {
                Console.WriteLine("Sorry, you are not qualified for our insurance.");
            }
            
            Console.ReadLine();

        }
    }
}
