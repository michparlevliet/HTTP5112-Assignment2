using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;

namespace HTTP5112_Assignment2_MichelleParlevliet.Controllers
{
    public class J3Controller : ApiController
    {
        /// PROBLEM J3: DOUBLE DICE (2014)

        /// <summary>
        /// The method will use the input value to represent the number of rounds played
        /// in a game where each player rolls the dice once per round. Each round, whichever
        /// player rolls the lower number gets the higher roll's amount taken off of their score.
        /// Whichever player is closest to 100 after the rounds are finished is the winner.
        /// **NOTE**
        /// I wanted to create this question with a random element to the dice rolls
        /// so that it would behave more like an actual game rather than the user inputting their 
        /// own roll values
        /// </summary>
        /// <param name="Rounds">The number of rounds the game will be played for</param>
        /// <returns>
        /// The final scores of each player and the number of rounds played.
        /// </returns>

        [HttpGet]
        [Route("api/j3/doubledice/{rounds}")]

        public IEnumerable<string> DoubleDice(int Rounds)
        {
            /// VARIABLES
           
            /// Defining a variable for the Random() class which I
            /// use with Next() method to create a randomized dice roll for 
            /// each player. SOURCE: https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-7.0
           
            Random r = new Random();

            int Player1Score = 100;
            int Player2Score = 100;
            string Player1Record = "";
            string Player2Record = "";

            /// Lists to hold the list of rolls values that will be 
            /// created by the loop below

            List<int> Player1RecordList = new List<int> {};
            List<int> Player2RecordList = new List<int> {};

            /// LOGIC

            /// Setting a for loop that runs for the input number of rounds.
            /// Each time it runs it asks for the random roll number for each player,
            /// which are then compared using if/elses statements to determine which
            /// player should lose how many points

            for (int i = 1; i <= Rounds; i++)
            {
                int Player1Roll = r.Next(1, 7);
                int Player2Roll = r.Next(1, 7);

                Player1RecordList.Add(Player1Roll);
                Player2RecordList.Add(Player2Roll);

                if (Player1Roll > Player2Roll)
                {
                    Player2Score = Player2Score - Player1Roll;
                }
                else if (Player2Roll > Player1Roll)
                {
                    Player1Score = Player1Score - Player2Roll;
                }
            }

            /// For loop that adds each roll to the PlayerRecord variable to be listed
            /// in the return statement

            for (int i = 0; i < Player1RecordList.Count(); i = i + 1)
            {
                Player1Record = Player1Record + Player1RecordList[i] + " ";
            }
            for (int i = 0; i < Player2RecordList.Count(); i = i + 1)
            {
                Player2Record = Player2Record + Player2RecordList[i] + " ";
            }

            /// Returns a string stating each roll from each player in order
            /// Returns a string stating the final score for each player as well as how
            /// many rounds were played

            return new string[]
            {
                "Player 1 rolled: "+Player1Record,
                "Player 2 rolled: "+Player2Record,
                "Player 1 has "+Player1Score+" points and player 2 has "+Player2Score+" points after "+Rounds+" rounds."
            };
        }
    }
}
