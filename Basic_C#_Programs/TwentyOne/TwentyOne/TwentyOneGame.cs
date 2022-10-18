using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //TwentyOneGame is a superclass/inheriting class as it inherits from the Game() class
    public class TwentyOneGame : Game, IWalkAway// if a class "Is A" Thing, then that INHERITS. TwentyOneGame IS A Game
    {

        public TwentyOneDealer Dealer { get; set; }

        // in order to implement Play() from Game (since it is an abstract method), we need to OVERRIDE the method
        public override void Play() // "satifies the contract" between TwentyOneGame and Game
            //this method will encompass ONE HAND of twenty one (see program.cs at play() method on line 30),
            //and will use method on ALL players
        {
            Dealer = new TwentyOneDealer(); //When the play() method is invoked in the main project, we are instanciating a new dealer
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            //resetting player and dealer's hand (and deck) so no errors occur ie: card counting
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");

            //making a foreach loop for all players to place their bets
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet); //Bet() method made in Player.cs to check if player has enough to play
                if (!successfullyBet)
                {
                    return; //"end this Play() method" and go back to the While loop on line 28, which starts the cycle all over again
                }
                //best way to track players and bets would be a dictionary. Key-Value pairs where it is Player-Bets pair
                //Done in Game.cs file on line 13
                Bets[player] = bet; //we've added to the dictionary
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: \n", player.Name);
                    Dealer.Deal(player.Hand);
                    //we need to check if player already has blackjack
                    if (i == 1)
                    {
                        // v--- checks Player's hand if they have BlackJack (See TwentyOneRules line 52)
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); //CheckForBlackJack() is static method, so we have preface with class name TwentyOneGame
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}!", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: \n");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has blackjack! Everyone loses! Pay up!");
                        foreach (KeyValuePair<Player, int> entry in Bets) //for every KVP in the dictionary Bets[],
                        {
                            //////// REVIEW, PUTTING IT ALL TOGETHER PART SIX //////
                            //assigned dealer the balance of everything
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }

            }
            ///////PART SEVEN/////
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n \n Hit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted! You lost your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                        }
                        return;
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); //entry.Key.Name = person will be in the 'entry' of the KVP; access values in KVP with "Key" or "Value", and the "Key" is the player, and Players have a name (.Name)
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    /* ^-- taking the list of Players and apply lambda query [Where() produces a list]
                     * Lambda expression: We are getting the list of Players where x name equals to the name in the dictionary 
                     * There will only be one person in each dictionary entry
                     * First() grabs the first person with that name (there will only be one)
                     * We will also grab the Balance and add what they bet times 2
                     */
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                //You can have a boolean with three possibilities (T/F/Null?)// Booleans usually can't take a null answer unless...
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand) ;// bool? turns boolean data type into a nullable boolean. Can now have the value "null"
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player]; //give player their money back
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2); // give player their winnings times 2
                    Dealer.Balance -= Bets[player]; //subtract bets from dealer's balance
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player]; //Bets[player] evaluates into an integer
                }
                // below is in the "for" loop because we have to ask each player if they want to play again
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
                {
                    player.isActivelyPlaying = true;
                    return;
                }
                else
                {
                    player.isActivelyPlaying = false;
                    return;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
