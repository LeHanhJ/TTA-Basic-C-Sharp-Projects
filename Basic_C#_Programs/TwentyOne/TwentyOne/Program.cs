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

            Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in d eck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
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



        //LAMBDA EXPRESSIONS

        // "Where x is x.Face card, and the Face card is equal to Ace (Face.Ace)"
        //it will COUNT the number of x in the deck that has an Ace as a face
        //int count = deck.Cards.Count(x => x.Face == Face.Ace);

        // "Make a list where x.Face is equal to all cards that has King as Faces, and compile them into a list (.ToList())
        //List<Card> newList = deck.Cards.Where(x=> x.Face == Face.King).ToList(); // ToList() method makes it a list

        //List<int> numberList = new List<int>() { 1, 2, 3, 345, 66, 456 };

        // Add 5 to every number in this list and sum them
        /*int sum = numberList.Sum(x => x + 5);*/ //.Sum() Method
                                                  //int max = numberList.Max(); //Find max number in list
                                                  //int min = numberList.Min(); //Find min number in list

        //int sum = numberList.Where(x => x > 20).Sum();


        //Console.WriteLine(sum);
    }
}
