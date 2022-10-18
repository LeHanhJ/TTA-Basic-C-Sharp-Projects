using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTimeNow = DateTime.Now; //assigned the current DateTime to dateTimeNow

            Console.WriteLine(dateTimeNow);

            Console.WriteLine("\nPlease enter a number and I will calculate what the time will be in that many hours.");
            int hoursEntered = Convert.ToInt32(Console.ReadLine()); //asks user to input amount of time to skip ahead to

            DateTime dateTimeFuture = dateTimeNow.AddHours(hoursEntered); //used the method AddHours() to dateTimeNow to add hours per how many hours were specified in hoursEntered
            Console.WriteLine("It is {0} right now. It will be {1} {2} hours in the future.", dateTimeNow, dateTimeFuture, hoursEntered);
            Console.Read();

        }
    }
}
