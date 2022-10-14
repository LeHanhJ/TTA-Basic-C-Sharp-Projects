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
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
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
