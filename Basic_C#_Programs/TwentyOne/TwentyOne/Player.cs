using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
     public class Player
    {
        //constructor
        public Player(string name, int beginningBalance) // making a constructor that takes two arguments
        {
            //V-- we're taking the arguments and assigning them properties in the class --V
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        //making properties of class
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount) //creating method Bet()
        {
            if (Balance - amount < 0) //"if the players balance minus the bet amount is less than 0..." then print
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                    return false;
            }
            else // otherwise subtract the amount bet from the balance and bool Bet() is true
            {
                Balance -= amount;
                return true;
            }
        }

        // ** Overloading an operator** //
        // ------------v return type 
        public static Game operator +(Game game, Player player)
        //what we are adding together----^------------^
        {
            game.Players.Add(player); //we have to instantiate a list
            return game;
        }

        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
