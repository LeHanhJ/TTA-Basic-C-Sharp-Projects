using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer // if something "HAS A" thing, it does not inherit; it has its own properties. A Dealer HAS A Deck, a dealer IS NOT a deck
    {
        public string Name { get; set; }
        public Deck Deck { get; set; } // <<<<<<<-------------------------------|
        public int Balance { get; set; }

        //Deal() method
        public void Deal(List<Card> Hand)
        {
            //adds the first card in the deck to the hand
            Hand.Add(Deck.Cards.First());
            //prints out what has been shown in the hand
            Console.WriteLine(Deck.Cards.First().ToString() + "/n");
            //removes card from deck
            Deck.Cards.RemoveAt(0);
        }
    }
}
