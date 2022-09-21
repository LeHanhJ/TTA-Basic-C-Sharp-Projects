using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess my favorite number! (1 to 100)");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessedNum = number == 72;


            do
            {
                switch (number)
                {
                    //Gives guesser a way to know how they are doing in terms of guessing the correct number
                    case 1:
                        Console.WriteLine("You are wayyy too cold. Please try again.");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 50:
                        Console.WriteLine("You are getting warmer. Please try again.");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    //Added cases 70-76 (minus the correct answer) to let guesser know how close they are to the correct number
                    case 70:
                        Console.WriteLine("You're in the ball park! Please try again");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 71:
                        Console.WriteLine("You're in the ball park! Please try again");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 73:
                        Console.WriteLine("You just missed it! Please try again");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 74:
                        Console.WriteLine("You just missed it! Please try again");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 75:
                        Console.WriteLine("You just missed it! Please try again");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 76:
                        Console.WriteLine("You just missed it! Please try again");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    //Congratulates the guesser for guessing the correct number
                    case 72:
                        Console.WriteLine("You guessed the number 72. That is correct, congrats!");
                        guessedNum = true;
                        break;

                    //default presents when guesser gueses any other number other than the ones listed in the cases.
                    default:
                        Console.WriteLine("Wrong answer! Please try again.");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }


            while (!guessedNum);

            Console.Read();

        }
    }
}
