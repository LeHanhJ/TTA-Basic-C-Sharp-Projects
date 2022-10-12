using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    class Employee : Person, IQuittable // class Employee inherits interface
    {
        //uses override so we are about to have method SayName() in abstract class Person run
        public override void SayName()
        {
            Console.WriteLine("Hello, my name is " + firstName + " " + lastName);
        }

        //implements Quit() method
        public void Quit()
        {
            Console.WriteLine("I am quitting. Goodbye.");
        }


        //
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // *Overloading the operators == and !=* //
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (!emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false;
        }
    }
}
