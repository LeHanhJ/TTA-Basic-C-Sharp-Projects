using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            int packageWeight;
            int packageWidth;
            int packageHeight;
            int packageLength;
            int packageDimensions;


            //Prompts user to enter package weight and converts it into an integer
            Console.WriteLine("Please enter the weight of your package:");
            packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Your package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else if (packageWeight <= 50)
            {
                Console.WriteLine("What is your package width?");
                packageWidth = Convert.ToInt32(Console.ReadLine());

                if (packageWidth > 50)
                {
                    Console.WriteLine("Your package is too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }

                else if (packageWidth <= 50)
                {
                    Console.WriteLine("What is your package height?");
                    packageHeight = Convert.ToInt32(Console.ReadLine());

                    if (packageHeight > 50)
                    {
                        Console.WriteLine("Your package is too big to be shipped via Package Express. Have a good day.");
                        Console.ReadLine();
                    }

                    else if (packageHeight <= 50)
                    {
                        Console.WriteLine("What is your package length?");
                        packageLength = Convert.ToInt32(Console.ReadLine());

                        if (packageLength > 50)
                        {
                            Console.WriteLine("Your package is too big to be shipped via Package Express. Have a good day.");
                            Console.ReadLine();
                        }
                        else if (packageLength <= 50)
                        {
                            packageDimensions = ((packageLength * packageWidth * packageHeight) * packageWeight) / 100;
                            float packagePrice = packageDimensions;
                            Console.WriteLine("Your estimated total for shipping for this package is: $" + packagePrice);
                            Console.ReadLine();

                        }


                    }
                }
            }
            else
            {
                Console.WriteLine("Something went wrong here... Please enter a valid whole number.");
                Console.ReadLine();
            }
        }
    }
}

