using System;
/// <summary>
/// Napolian Myat
/// Project: Homework1
/// Date: 01/31/2022
/// Purpose: For this homework, we will begin creating our Text Adventure using:
/// •	Use assignment statements
/// •	Use simple input & output
/// •	expressions and casting
/// •	the strings class

/// </summary>
namespace MyatN_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string name;    //save user name
            string playGame;    //whether to play game or not

            //Introduction
            //•	Provide the name of the game
            //•	Provide instructions for how to play the game
            Console.WriteLine("Welcome to Morg's Diabetic Sugar Adventure");
            Console.WriteLine("__________________________________________\n");


            // User starts here – ask for basic information such as user name.
            //•	Ask the user for their name, read it in and save it (It is used multiple times throughout the game)
            Console.WriteLine("Please enter your character name: ");
            name = Console.ReadLine();

            //Greetings
            //•	Provide the initial narration, using the name provided by the user.
            //change font color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Nice to meet you, " + name + " I hope you are prepared to die in a sugar coma!\n");
            //change color back
            Console.ForegroundColor = ConsoleColor.White;

            // Section to setup initial storyline
            //•	Provide instructions for how to play the game
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Morg's Diabetic Sugar Adventure is an interactive text based game.\nDuring the game you will" +
                " be asked for decisions and to enter input.\nYou will be provided with all that you need to know as you play " +
                "the game\nand only need a keyboard to play.  Enjoy the adventure!\n");

            //•	Add a section inquiring if the user wants to start playing the game and asking for a Y/ N response.
            Console.WriteLine("Are you ready to play (Y/N)?");
            playGame = Console.ReadLine().Trim().ToUpper(); //trim/toupper senitize userinput

            //In case player enters yes or no instead of y or n
            if(playGame == "YES" || playGame == "NO")
            {
                Console.WriteLine("*sigh*.... we asked for a 'Y' or an 'N'");
                playGame = playGame.Substring(0, 1);

            }
            //test
            Console.WriteLine(playGame);

            if (playGame != "Y")
            {
                //They gave us anything BUT Y
                return;
            }
            else
            {

            }




            Console.ForegroundColor = ConsoleColor.White;
            // What is the flow?
            // path to front door
            // challenge to get in front door
            // what do you see when get in the door?
            // User finds the dungeon door and escapes with the Hershey Candy Golden Globes

        }
    }
}
