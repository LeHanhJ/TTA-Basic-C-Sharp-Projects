using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.FirstName = "Jill";
            emp1.LastName = "Masterson";
            emp1.Id = 1;

            emp1.FirstName = "Bobby";
            emp1.LastName = "Lau";
            emp1.Id = 2;

        }
    }
}
