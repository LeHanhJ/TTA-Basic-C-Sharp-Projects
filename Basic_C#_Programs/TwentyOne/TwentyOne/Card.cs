using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{

    // Class vs Object: Class is the cookie cutter vs Object is the cookie; OR Class is the recipe for food vs Object is the cooked food
    public struct Card
    {
        // CONSTRUCTOR : its values are assigned to an object upon creation
        //public Card() // method name is always name of the class (ie Card() method)
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        // C# has a nice shorthand way of creating properties (ex: suit/face) in objects (ex: card) vvv
        public Suit Suit { get; set; } // by making PROPERTY string suit "public", it makes it accessible to other parts of the program
        public Face Face { get; set; }
        //  public datatype datatypename { "get" or "set" property }
    }

    // ENUM

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
