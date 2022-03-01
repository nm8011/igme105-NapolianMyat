using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// Project: Homework2
/// Date: 01/31/2022
/// Modified: 02/21/2022
/// Purpose: Extension of hw1
/// For this homework, we will begin creating our Text Adventure using:
///•	Random class
///•	string and math class methods
///•	If Statements and Relational\ Boolean Operators
///•	Nested If Statements
///•	Switch Statements
///•	Loops
/// </summary>
namespace MyatN_HW1
{
    static class Setup
    {
        /// <summary>
        /// Introduce the game
        /// </summary>
        public static void Welcome()
        {
            //leave it black
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome to Mystical Grotto");
            Console.WriteLine("__________________________________________\n");
        }
        /// <summary>
        /// Tell player how to play the game
        /// </summary>
        public static void Rules()
        {
            // Section to setup initial storyline
            //•	Provide instructions for how to play the game
            Console.WriteLine("\tMystical Grotto is an interactive text based game.\nDuring the game you will" +
                " be asked for decisions and to enter input.\nYou will be provided with all that you need to know as you play " +
                "the game\nand will only require a keyboard to play. Enjoy the adventure!\n");
            Console.ForegroundColor = ConsoleColor.White;//change color back

        }
        /// <summary>
        /// Prompt user name
        /// </summary>
        /// <returns></returns>
        public static string GetName()
        {
            //Variables
            string name;
            bool valid = false;
            // User starts here – ask for basic information such as user name.
            //•	Ask the user for their name, read it in and save it (It is used multiple times throughout the game)
            Console.Write("Please enter your character name: ");
            name = Console.ReadLine().Trim();
            do
            {
                //user press 'enter'
                if (string.IsNullOrEmpty(name))
                {
                    //will loop again and ask for valid name
                    valid = false;
                    Console.WriteLine("Sorry, you have not inputted a name. Please input a valid name!");
                    name = Console.ReadLine().Trim();
                }
                else
                {
                    //exits loop
                    valid = true;
                }
            }
            while (valid == false);
            //Greetings
            //•	Provide the initial narration, using the name provided by the user.
            //change font color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Nice to meet you, {0} I hope you are prepared to perish in a dark damp lair!\n", name);
            return name;
        }
        /// <summary>
        /// Get 'Y'es or 'N'o to play the game or not 
        /// </summary>
        /// <returns></returns>
        public static void PlayGame()
        {
            //Variables
            string playGame;
            //•	Add a section inquiring if the user wants to start playing the game and asking for a Y/ N response.
            Console.WriteLine("Are you ready to play (Y/N)?");
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.White;
            playGame = Console.ReadLine().Trim().ToUpper(); //trim/toupper senitize userinput

            //In case player enters yes or no instead of y or n
            if (playGame == "YES" || playGame == "NO")
            {
                if (playGame == "NO")
                {
                    Console.Clear();
                    Console.WriteLine("\n*sigh*.... we asked for a 'Y' or an 'N'");
                    Console.WriteLine("Anywhoo, You have decided you are not ready to play the game.\nCome again when you are ready. :)");
                    Environment.Exit(0); //exits program
                }
                playGame = playGame.Substring(0, 1);

            }
            //test
            //Console.WriteLine(playGame);
            if (playGame != "Y")
            {
                Console.Clear();
                Console.WriteLine("You did not enter 'Y'es. You have decided you are not ready to play the game.\nCome again when you are ready. :)");
                Environment.Exit(0);
                //They gave us anything BUT Y
            }
            else
            {
                //nth code continues
            }
        }
    }
}
