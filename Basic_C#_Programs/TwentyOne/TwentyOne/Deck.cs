using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        // CONSTRUCTOR : values are assigned to an object upon creation. public Deck() is a constructor; it is in class Deck
        public Deck()
        {//   vv----This ("Cards") refers to the PROPERTY of the CLASS --^^
            Cards = new List<Card>();

            // "For each face in a list of 13 cards, we need to loop through 4 times. Once for each suit.
            // User a "Nested For Loop"

            List<string> Suits = new List<string>() { "Hearts", "Clubs", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {   
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);

                }
            }



        }
        // Cards'-----------v---property is a List 
        //      V-----------v------------------|
        public List<Card> Cards { get; set; }
    }
}
