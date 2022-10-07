using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created an object of type IQuittable
            IQuittable quitter = new Employee();

            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();

            //calling the Quit() method on the new object
            quitter.Quit();

            Console.ReadLine();

        }
    }
}
