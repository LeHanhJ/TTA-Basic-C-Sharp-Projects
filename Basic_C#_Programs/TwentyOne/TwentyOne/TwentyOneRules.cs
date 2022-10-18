using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        // V -- this will only be used inside this class || Face is the Value (numbered values), 
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //naming private convention is putting underscore before name
        {
            //instantiating the dictionary entries
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1 //we can only assign a key one value. We will add ten to the Ace in a later method/computer logic
        };
        //making a method to return integer array of possible values related to an Ace

        ///////REVIEW, PUTTING IT ALL TOGETHER PART FIVE///////
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]); //we are taking a hand and summing the card values, established above, and we are taking each Face value in the hand
            result[0] = value; //getting value and putting it into the array result[]
            if (result.Length == 1)
            {
                return result;
            }
            ///////REVIEW, PUTTING IT ALL TOGETHER PART SIX///////
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10); // value = value + (i * 10)
                result[i] = value;
            }
            return result;
        }

        //making a method to check for blackjack
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max(); // <------------|
            if (value == 21) return true; // < -- checks if max volume is 21 
            else return false;

        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min(); //get all the values of the possible hands, and the minimum is assigned to "value"
            if (value > 21) return true; //and if the minimum possible hand is greater than 21, then we know all values are busted
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);
       
            int playerScore = playerResults.Where(x => x < 22).Max(); //"Get me the integer that is less than 22, and give me the Max value of that"
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }

    }
}
