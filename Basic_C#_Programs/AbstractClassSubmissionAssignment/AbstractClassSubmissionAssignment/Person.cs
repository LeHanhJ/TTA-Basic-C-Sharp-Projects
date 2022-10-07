using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment
{
    public abstract class Person
    {
        //establishes properties firstName and lastName of class Person
        public string firstName;
        public string lastName;

        //made virtual void method SayName() in abstract class Person so other classes can override it
        public virtual void SayName()
        {

        }
    }
}
