using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // *Overloading the operators == and !=* //

        //sets the == operator as a boolean and defined parameters
        public static bool operator== (Employee emp1, Employee emp2)
        {
            //states that if the Id of emp 1 is equal to emp 2, then return true; otherwise return false
            if (emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false;
        }

        public static bool operator!= (Employee emp1, Employee emp2)
        {
            //as above, but the opposite
            if (!emp1.Id.Equals(emp2.Id))
            {
                return true;
            }
            return false;

        }
    }
}
