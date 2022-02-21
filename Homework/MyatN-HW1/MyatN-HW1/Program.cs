using System;
/* Name: Geoff, Xavier, and Napolian
 * Project: Trouble Game
 * Date: 1/21/2022
 * Purpose: To create a console version of the Trouble board game
 * Modifications: (PE03, 1/21/2022)
 */
namespace PETrouble
{
    class Program
    {
        static void Main(string[] args)
        {
            //Attributes - Players 

            // Real Person
            /*
             * Pieces - # of pieces
             * 
             */
            //const int numOfPlayers;

            int PlayerPiece1;
            int PlayerPiece2;
            int PlayerPiece3;
            int PlayerPiece4;

            string playerAgeRead;
            string PieceColor;
            string PlayerName;

            // AI Person - Variables
            int AIPlayerPiece1;
            int AIPlayerPiece2;
            int AIPlayerPiece3;
            int AIPlayerPiece4;

            string AIName;
            string AIColor;
            /* Pieces
             * Piece Color
         * AIName
         */

            //Board
            /* Board Locations
             * Board Length
             */
            int PlayerPosition = 0;
            int AIPosition = 14;
            // Move pieces
            // Rolling Dice
            // Reset (i.e. send a piece home - poor opponent)
            // Setup game
            // Game Status (who won/lost)
            // Turn order (who's up!)

            //ask player name
            Console.Write("Welcome player, to our horrible game of (not) Trouble, by what name can we call you? :");
            PlayerName = Console.ReadLine();
            Console.WriteLine();

            //ask player age
            Console.Write("What is your age? ");
            playerAgeRead = Console.ReadLine();
            Console.WriteLine();

            //checking to see if age is a real valid number
            int ageNum;

            bool success = int.TryParse(playerAgeRead, out ageNum);

            if (!success)
            {
                Console.WriteLine("You didn't enter a valid age number. So you are now 2 years old. ha. You are baby. Your actions have consequences.");
                ageNum = 2;
            }
            else
            {
                ageNum = int.Parse(playerAgeRead);
            }

            Console.WriteLine();
            //ask player color
            Console.Write("Thank you {0}({1}),Which color do you wish to be? (B)lue, (R)ed, or (Y)ellow:", PlayerName, ageNum);
            PieceColor = Console.ReadLine();

            Console.WriteLine();

            //Welcome
            Console.WriteLine("\t\t\tWelcome {0}({1}) to the Trouble Pop-O-Matic Game!", PlayerName, ageNum);
            Console.WriteLine("\t\t ----------------------------------------------------- \n");

            //Rules
            Console.WriteLine("Rules:");
            Console.WriteLine(" ----------------------------------------------------------------------------------");

            Console.WriteLine("Trouble is easy to play. \n" +
                "\t -Players will take turns to roll a die.\n  \t -Roll a 6 to start a piece on the board.\n \t -Get all 4 pieces around before any other player. \n \t -Land on another player piece and send them back to start. \n ");

            Console.WriteLine(" ----------------------------------------------------------------------------------");

            //wishing gl
            Console.WriteLine("\t\t\t Good Luck! \n");



            //ask player ai's name
            Console.Write("What name do you wish to grant thy formidable enemy(AI)? :");
            AIName = Console.ReadLine();
            //ai automatically granted the color black
            AIColor = "Black";







            //Stats
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("|\tPlayerName: " + PlayerName + "(" + ageNum + ")" + " \tPiece Color: " + PieceColor + "\t\t Player position: " + PlayerPosition + "\t|");
            Console.WriteLine("|\tAIName: " + AIName + " \t\t Piece Color: " + AIColor + "\t AI position: " + AIPosition + "\t|");
            Console.WriteLine("--------------------------------------------------------------------------------");

            //get date
            DateTime now = DateTime.Now;

            //print time/date (formatted)
            Console.WriteLine("The current date and time is: " + now.ToString("MM/dd/yyyy hh:mm tt"));



        }
    }
}
