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
    }
}
