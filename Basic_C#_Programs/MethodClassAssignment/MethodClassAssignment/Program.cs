using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiate the class
            Methods practiceMethods = new Methods();

            //passing in two numbers
            practiceMethods.sum(2,5);
            //specifying parameters by name
            practiceMethods.sum(num1: 9, num2: 6);

            Console.ReadLine();

        }

    }
}
