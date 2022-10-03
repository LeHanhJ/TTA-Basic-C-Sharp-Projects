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
        public int SquareNum(int num)
        {
            int square = num * num;
            //remember, need "return;" to return value
            return square;
        }

        public double DecimalNum(double num)
        {
            double deciNum = num * .04;
            return deciNum;
        }

        public int StringNum(string num2)
        {
            int numAgain = Convert.ToInt32(num2);
            int product = numAgain * 1000;
            return product;
        }

    }
}
