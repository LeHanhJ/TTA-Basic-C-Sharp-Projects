using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //making an list of integers


            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(19);
            intList.Add(10);

            intList.Remove(10);

            Console.WriteLine(intList[0]);
            

            /// making a string list

            List<string> stringList = new List<string>();
            stringList.Add("Hello\n");
            stringList.Add("\t This is a string list \n");
            stringList.Add("\t \t I should be going further right...");


            Console.WriteLine(stringList[1]);
            Console.ReadLine();


            //////////////////ARRAYS//////////////////

            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 1;
            numArray[2] = 20;
            numArray[3] = 3090;
            numArray[4] = 576;

            //unlike above, do not put LENGTH in new int[x], and put in curly braces
            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //and unlike the others above, C# knows to just judge by the curly brackets
            int[] numArray2 = { 2, 3, 4, 564, 622 };

            numArray2[2] = 32;

            Console.WriteLine(numArray2[2]);
            Console.ReadLine();



        }
    }
}
