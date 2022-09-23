using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //// INTEGER ARRAY ///////

            //int[] testScores = { 98, 99, 85, 65, 82, 70, 52, 94, 100, 69};

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();


            ////// STRING ARRAY ///////

            //string[] names = { "Jesse", "Ann", "Jake", "Alec", "Serena", "Hanh" };

            //for (int n = 0; n < names.Length; n++)
            //{
            //   Console.WriteLine(names[n]);
            //}
            //Console.ReadLine();


            ///// INTEGER LIST //////
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(100);
            //testScores.Add(67);
            //testScores.Add(91);
            //testScores.Add(81);
            //testScores.Add(55);
            //testScores.Add(32);
            //testScores.Add(72);

            ////"score" is a variable name
            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " +  score);
            //    }
            //}
            //Console.ReadLine();


            ////////// STRING LIST ///////

            //List<string> names = new List<string>() { "Jesse", "Ann", "Jake", "Alec", "Serena", "Hanh" };

            //foreach (string name in names)
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 66, 89, 54 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            //finding out how many passing scores there are in the list
            // NOTE: LIST has COUNT property, ARRAY has LENGTH property
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();


        }
    }
}
