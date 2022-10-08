using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //the class Game is an abstract class because it is always a specific type of game. ex Poker, 21, etc
    { //     ^-------- abstract keyword to make class an abstract. Can no longer instantiate in main program
        //add properties to Game class (what does the Game class have?)
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        // an Abstract method can only exist in an ABSTRACT CLASS, and it contains NO implementation
        // This line states "any class that is inheriting this class MUST have this/implement Play() method
        public abstract void Play();

        //method to print out list of players for game that was being played
        //void method so we don't need to use it for all games, and we can just call it when we would like it
        // VIRTUAL: a virtual method inside of an abstract class -- This method gets inherited by its inheriting class...
        // but it has the ability to override it (Virtual methods HAVE implementation but it CAN be overridden)
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }


    }
}
