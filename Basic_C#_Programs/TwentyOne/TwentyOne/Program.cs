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
            deck.Shuffle(3);

            // previous iterations of code 10/3/22
            // int timesShuffled = 0;
            //deck = Shuffle(deck: deck, out timesShuffled, 3); // try to comment this out and see what you get



            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //copied and pasted into deck.cs; check notes there and compare to this code

        ////public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        ////{
        ////    timesShuffled = 0;

        ////    for (int i = 0; i < times; i++)
        ////    {
        ////        timesShuffled++;
        ////        List<Card> tempList = new List<Card>();
        ////        Random random = new Random();

        ////        while (deck.Cards.Count > 0)
        ////        {
        ////            int randomIndex = random.Next(0, deck.Cards.Count);
        ////            tempList.Add(deck.Cards[randomIndex]);
        ////            deck.Cards.RemoveAt(randomIndex);
        ////        }
        ////        deck.Cards = tempList;
        ////    }

        ////    return deck;

        ////}

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i=0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
