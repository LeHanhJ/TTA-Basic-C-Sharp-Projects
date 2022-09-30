using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // OBJECTS are items that can be represented by a computer program. They are often meant to represent real world things. 
            // In the world around you, you are surrounded by objects. OBJECTS have STATE and BEHAVIORS

            // The STATE of the object would be SIZE, COLOR, ETC

            Deck deck = new Deck();
            deck = Shuffle(deck); // try to comment this out and see what you get

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> tempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                tempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = tempList;
            return deck;

        }
    }
}
