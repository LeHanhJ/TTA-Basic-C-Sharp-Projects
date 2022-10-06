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
        // Created the out variable numDivided, which is then being used in the method...
        public void outputParameters(out int voidMethodNumber)
        {
            //... by changing it to the value of 2
            voidMethodNumber = 5;
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
