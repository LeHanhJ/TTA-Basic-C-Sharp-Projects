using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer // if something "HAS A" thing, it does not inherit; it has its own properties. A Dealer HAS A Deck, a dealer IS NOT a deck
    {
        public string Name { get; set; }
        public Deck Deck { get; set; } // <<<<<<<-------------------------------|
        public int Balance { get; set; }

        //Deal() method
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());//adds the first card in the deck to the hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);//prints out what has been shown in the hand
            using (StreamWriter file = new StreamWriter(@"C:\Users\dell\text.txt", true)) //to log down cards that have been dealt
            { // 'true' appends the text to the file --------------------^

                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            
            } //'using' clears out memory once it reaches this last curly bracket
            Deck.Cards.RemoveAt(0); //removes card from deck
        }
    }
}
