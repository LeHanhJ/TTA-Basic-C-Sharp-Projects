using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
     public class Player
    {
        //making properties of class
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        // ** Overloading an operator** //
        // ------------v return type 
        public static Game operator +(Game game, Player player)
        //what we are adding together----^------------^
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
