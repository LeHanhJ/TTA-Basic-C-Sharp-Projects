using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciating the MathOperation class to be able to be used in the main program
            MathOperation mathOperation = new MathOperation();


            Console.WriteLine("Please enter a number and I will see what the number is if we square it");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a dollar amount if we were to buy something in Hawai'i that was the same price in Oregon.");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("And another number to multiply by 1000 please:");
            string num3 = Console.ReadLine();


            Console.WriteLine(num +" multiplied by itself is " + mathOperation.operations(num));
            Console.WriteLine("In Hawai'i, you would pay $" + mathOperation.operations(num2) + " for the same item that costs $" + num2 + " in Oregon");
            Console.WriteLine(num3 + " multiplied by 1000 is " + mathOperation.operations(num3));

            Console.ReadLine();
        }
    }
}
