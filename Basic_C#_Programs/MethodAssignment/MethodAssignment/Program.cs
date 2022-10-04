using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Methods methodAssignment = new Methods();

            

            Console.WriteLine("Please enter up to two numbers to perform a math operation on them.");
            Console.WriteLine("Enter your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number (optional):");

            //try/catch statement to catch optionalNum if user does not put input in
            try
            {
                //we need this because setting an optionalNum will make it into a string. Easier to make try/catch to try when 
                // there is an optional second number inputted
                int optionalNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(methodAssignment.TwoIntegerMethod(num1, optionalNum));
            }

            //otherwise the catch would just use the first inputted parameter and use the default for the optional parameter
            catch
            {
                Console.WriteLine(methodAssignment.TwoIntegerMethod(num1));
            }

           
            Console.ReadLine();
        }
    }
}
