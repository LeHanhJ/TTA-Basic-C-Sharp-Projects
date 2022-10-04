using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{

    //first put "public" in front of class to have other files in program able to access it
    public class MathOperation
    {
        //squares a nnumber entered in variable num
        public int operations(int num)
        {
            int square = num * num;
            //REMEMBER!! need "return;" to return value
            return square;
        }

        //multiplies by 4%, the tax amount in Hawai'i and returns it
        public int operations(decimal num2)
        {
            int result = Convert.ToInt32(num2 * 1.04m);
            return result;
        }

        //converts user input in the method rather than the main program itself.
        public int operations(string num3)
        {
            int numAgain = Convert.ToInt32(num3);
            int product = numAgain * 1000;
            return product;
        }

    }
}
