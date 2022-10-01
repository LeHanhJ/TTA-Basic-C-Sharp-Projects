using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Class
    {

        // Creating all our methods! //

            // we need to write 'public' before our methods so the other program files can see these methods
        public int AddNum(int num)
        {
            int sum = num + 100000;
            // without return sum; we would not be able to see a value 
            return sum;
        }

        public int MultiplyNum(int num)
        {
            int product = num * 100000;
            return product;
        }

        public int DivideNum(int num)
        {
            int quotient = num / 100000;
            return quotient;
        }

    }
}
