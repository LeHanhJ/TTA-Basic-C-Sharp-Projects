using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates the Employee class
            Employee employee = new Employee();
            //initializes  first and last name of employee
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            // calls the superclass method of SayName()
            employee.SayName();
            Console.ReadLine();

        }
    }
}
