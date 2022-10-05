using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {

        static void Main(string[] args)
        {

            ClassExample operations = new ClassExample();


            Console.WriteLine("Please enter a number and we will divide that number by 2.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // call method on the inputted number and displays output to screen
            operations.outputInt(num1);


            outputParameters(out num1);

            Console.WriteLine("After method call, value of num 1 : {0}", num1);
            Console.ReadLine();

        }
    }
}
