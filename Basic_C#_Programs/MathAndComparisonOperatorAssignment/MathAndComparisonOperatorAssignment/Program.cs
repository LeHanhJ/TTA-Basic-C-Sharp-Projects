using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction of the program
            Console.WriteLine("Anonymous Income Comparison Program (Please press Enter)");
            Console.ReadLine();


            //Person 1
            Console.WriteLine("Person 1");
            string hourlyRate = "What is your hourly rate?";
            Console.WriteLine(hourlyRate);
            string personOneRate = Console.ReadLine();
            int rateOne = Convert.ToInt32(personOneRate);

            

            string hoursWorked = "How many hours do you work per week?";
            Console.WriteLine(hoursWorked);
            string personOneWorked = Console.ReadLine();
            int workedOne = Convert.ToInt32(personOneWorked);


            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine(hourlyRate);
            string personTwoRate = Console.ReadLine();
            int rateTwo = Convert.ToInt32(personTwoRate);
            

            Console.WriteLine(hoursWorked);
            string personTwoWorked = Console.ReadLine();
            int workedTwo = Convert.ToInt32(personTwoWorked);


            //Add both per person, and compare income

            int personOneIncome = rateOne * workedOne *  52;
            int personTwoIncome = rateTwo * workedTwo * 52;

            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(personOneIncome);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(personTwoIncome);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool incomeComparison = personOneIncome > personTwoIncome;
            Console.WriteLine(incomeComparison);

            Console.ReadLine();




        }
    }
}
