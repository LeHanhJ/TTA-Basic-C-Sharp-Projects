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

            MathOperation mathOperation = new MathOperation();
            Console.WriteLine("Please enter a number and I will see what the number is if we square it, and multiply it by 3.25");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And another number to multiply by 1000 please:");
            string num2 = Console.ReadLine();
            
            Console.WriteLine(num +" multiplied by itself is " + mathOperation.SquareNum(num));
            Console.WriteLine("In Hawai'i, you would pay $" + mathOperation.DecimalNum(num) + " more in taxes than you would in Oregon for the same price.");
            Console.WriteLine(num2 + " multiplied by 1000 is " + mathOperation.StringNum(num2));
            Console.ReadLine();
        }
    }
}
