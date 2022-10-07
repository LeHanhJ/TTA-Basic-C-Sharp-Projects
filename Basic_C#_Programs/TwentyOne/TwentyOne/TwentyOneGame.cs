using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //TwentyOneGame is a superclass as it inherits from the Game() class
    public class TwentyOneGame : Game // if a class "Is A" Thing, then that INHERITS. TwentyOneGame IS A Game
    {
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
