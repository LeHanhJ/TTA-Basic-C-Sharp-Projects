using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        //gave Person() class properties of FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Created void method called SayName() to print out person's full name to console as instructed by steps

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

    }
}
