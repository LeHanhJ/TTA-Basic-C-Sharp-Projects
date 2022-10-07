using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Game
    {
        //add properties to Game class (what does the Game class have?)
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }



        //method to print out list of players for game that was being played
        //void method so we don't need to use it for all games, and we can just call it when we would like it
        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }


    }
}
