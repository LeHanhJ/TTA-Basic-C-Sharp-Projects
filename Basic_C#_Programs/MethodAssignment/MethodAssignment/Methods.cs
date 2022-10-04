using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Methods
    {
        public int TwoIntegerMethod(int num1, int optionalNum = 1)
        {
            int TwoInt = ((num1 * 10) / optionalNum);
            return TwoInt ;
        }

    }
}
