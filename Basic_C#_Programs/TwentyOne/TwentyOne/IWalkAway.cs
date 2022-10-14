using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    interface IWalkAway
    {
        // no implementation details in interfaces, like abstract classes
        // .NET supports inheriting multiple interfaces, but just inheriting one class
        void WalkAway(Player player);
        // Any class that we have inherit from IWalkAway has to implement WalkAway() Method and has take in Player player parameters
        // and has to return a void


    }
}
