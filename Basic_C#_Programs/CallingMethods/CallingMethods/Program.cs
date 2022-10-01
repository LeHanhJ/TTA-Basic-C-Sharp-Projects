using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {

                // pulls from class file Class (Class.cs) and instantiates a new Class() object [We must do this to every class we want to reference in this main file]
            Class operation = new Class();

            Console.WriteLine("Please enter a number to see the results for addition, multiplication, and division of your number and 10,000.");
            int num = Convert.ToInt32(Console.ReadLine());

                // calls upon operation (the 'Class()' that was instantiated above) and calls various methods to be performed (methods are within the class)
            Console.WriteLine(operation.AddNum(num));
            Console.WriteLine(operation.MultiplyNum(num));
            Console.WriteLine(operation.DivideNum(num));

            Console.ReadLine();

        }

        
        


    }
}
