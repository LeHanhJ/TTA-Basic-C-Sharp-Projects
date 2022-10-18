using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    class Program
    {
        public class Student
        {
            public string fName;
            public string lName;
            public int Id;
            public int courseNumber;

            public Student(string fName, string lName) : this(fName, lName, 1, 101) //construct chaining inheriting from below constructor
            {

            }

            public Student(string fName, string lName, int Id) : this(fName, lName, Id, 101) //construct chaining inheriting from below constructor
            { 

            }

            public Student(string fName, string lName, int Id, int courseNumber) //creating a constructor
            {
                this.fName = fName;
                this.lName = lName;
                this.Id = Id;
                this.courseNumber = courseNumber;
            }


        }
        static void Main(string[] args)
        {
            const string greeting = "Hello, my friend!"; // created a constant for a greeting string
            var money = 200.00; //created a variable money, which C# identifies correctly as a double

            
        }
    }
}
