using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class ClassExample
    {
        public void outputInt(int num1)
        {
            int quotient = num1 / 2;
            Console.WriteLine(quotient);
        }

        //output parameters
        public void outputParameters(out int numDivided)
        {
            numDivided = 2;
        }

        //overloaded method and declared to be static
        public static void outputInt(string num1, int num = 2)
        {
            int RealNum = Convert.ToInt32(num1);
            int NumQuotient = RealNum / num;
            Console.WriteLine(NumQuotient);
        }
    }
}
