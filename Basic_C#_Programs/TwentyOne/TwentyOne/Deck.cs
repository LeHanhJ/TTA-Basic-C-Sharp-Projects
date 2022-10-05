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
        public Deck() // constructor first (constructor constructs a class) that makes Deck() have 52  cards with diff faces and suits
        {//   vv----This ("Cards") refers to the PROPERTY of the CLASS --^^ Property is what the class has to describe it.
            //ie, a Deck has Cards (Cards is also another class that has Suit and Face already assigned to it
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


        //cut and pasted from program
        //if it has "static" after "public", that means you can call the method without it applying to the specific Deck that we created
        //if we TAKE OUT "static", the method Shuffle() belongs to the object Deck
        //Since we are operating on a Deck, we can get rid off Deck deck

        // and since we are not returning anything in the method (it's doing it all internally), we don't need Deck
        public void Shuffle(int times = 1)
        {

            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = tempList;
            }

        }
    }
}
