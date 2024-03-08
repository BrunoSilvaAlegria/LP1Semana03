using System;

namespace RPS
{
    
    class Program
    {   /// <summary>
    /// Method that uses two enumerations to store and determine possible
    /// results to a Rock/Paper/Scissors game played with two players
    /// </summary>
    /// <param name="player1"></param>
    /// <param name="player2"></param>
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            //Creates a variable that will be used to store possible situations
            GameStatus status;

            //Calls both of the players options
            GameItem p1 = (GameItem)Enum.Parse(typeof(GameItem), player1);           
            GameItem p2 = (GameItem)Enum.Parse(typeof(GameItem), player2);

            if (player1 == player2)
            {
                //Calls the Draw situation
                status = GameStatus.Draw; // Draw

            }
            if (((player1 == "Rock") && (player2 == "Scissors")) ||
                ((player1 == "Scissors") && (player2 == "Paper")) ||
                ((player1 == "Paper") && (player2 == "Rock")))
            {
                //Calls the Player1Wins situation
                status = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {   //Calls the Player2Wins situation
                status = GameStatus.Player2Wins; // Player 2 wins
            }

            //Returns the situation as an integrable number used in Main
            return (int) status;
        }   
    }
}
