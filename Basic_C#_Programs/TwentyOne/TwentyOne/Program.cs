using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";


            Console.WriteLine("Welcome to the {0}!\nLet's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            ///Database Access Part Four - REVIEW THIS!!! See below for more code//
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            //

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only with no decimals.");
            }




            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            //program that will run if user says "yes" to wanting to play 21
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
            {
                Player player = new Player(playerName, bank); //Player(playerName, bank) from the player class, after making a constructor
                player.Id = Guid.NewGuid();//GUID means Globally Unique IDentifier to set a unique identifier to each user

                using (StreamWriter file = new StreamWriter(@"C:\Users\dell\text.txt", true))
                {
                    file.WriteLine(player.Id);
                }

                Game game = new TwentyOneGame(); //polymorphism: establishing new game as a 21Game (is both Game and TwentyOneGame)
                game += player; //adding a player to the game
                player.isActivelyPlaying = true; //isActivelyPlaying = property of player class; will constantly check in a while loop if the player is still playing

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play(); //this is just one hand played/iteration through the method  
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            //if user chooses "no", then it will skip to here
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.ReadLine();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                        (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); //naming and eastablishing data type for SQL to prevent SQL injection
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); //GetType() grabs data type you are working with; gets a data type "Type"
                command.Parameters["@ExceptionMessage"].Value = ex.Message; //Message is already a string
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]); //reader object, in the Id field in the SQL table
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;

        }

    }
    /*copied and pasted into deck.cs; check notes there and compare to this code

    //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
    //{
    //    timesShuffled = 0;

    //    for (int i = 0; i < times; i++)
    //    {
    //        timesShuffled++;
    //        List<Card> tempList = new List<Card>();
    //        Random random = new Random();

    //        while (deck.Cards.Count > 0)
    //        {
    //            int randomIndex = random.Next(0, deck.Cards.Count);
    //            tempList.Add(deck.Cards[randomIndex]);
    //            deck.Cards.RemoveAt(randomIndex);
    //        }
    //        deck.Cards = tempList;
    //    }

    //    return deck;

    //}

    //public static Deck Shuffle(Deck deck, int times)
    //{
    //    for (int i=0; i < times; i++)
    //    {
    //        deck = Shuffle(deck);
    //    }
    //    return deck;

    ///////LAMBDA EXPRESSIONS////////

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

    ///////FILE I/O ////////
    ///string text = "Here is some text.";
    ///File.WriteAllText(@"C:\Users\dell\text.txt", text); //@ means to read string 
    ///... then to read...
    /// string text = File.ReadAllText(@"C:\Users\dell\text.txt");
    /// --------^ hover over and should have the text assigned to it
    /// 
    ///////DATETIME
    ///DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);//DateTime is a value type, also a Struct so is non-nullable
    //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);
    //....then....
    //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

}
