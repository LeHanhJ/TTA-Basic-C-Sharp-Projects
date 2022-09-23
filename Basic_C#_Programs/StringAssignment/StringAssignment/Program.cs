using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Hanh";
            string quote = "The woman said, \"Hello, " + name + ".\" \n\"I hope you are enjoying your stay here\" \n \t I just looked at her.";
            string fileName = "C:\\Users\\Hanh \n"; //Can also use @ in front of double quotes to use on long file names

            bool trueOrFalse = name.Contains("n");
            int length = name.Length;

            name = name.ToUpper();


            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Hanh. \n The woman scoffed and rolled her eyes. \n \t \"I know who you are, I just said your name a second ago.\"");


            Console.WriteLine(fileName);
            Console.WriteLine(quote);

            Console.WriteLine(sb);

            Console.WriteLine(trueOrFalse);
            Console.WriteLine(length);
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
