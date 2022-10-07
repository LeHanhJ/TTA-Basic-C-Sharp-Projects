using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //TwentyOneGame is a superclass/inheriting class as it inherits from the Game() class
    public class TwentyOneGame : Game // if a class "Is A" Thing, then that INHERITS. TwentyOneGame IS A Game
    {
        // in order to implement Play() from Game (since it is an abstract method), we need to override the method
        public override void Play() // "satifies the contract" between TwentyOneGame and Game
        {        
            // MUST implement above to have method Play()
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
    }
}
