using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// Project: Homework3
/// Date: 01/31/2022
/// Modified: 03/02/2022
/// Purpose: Extension of hw1
/// For this homework, we will begin creating our Text Adventure using:
///•	Random class
///•	string and math class methods
///•	If Statements and Relational\ Boolean Operators
///•	Nested If Statements
///•	Switch Statements
///•	Loops
///•	Method Overloading / Variable Scope
///•	Method parameters returning Values
///•	Classes
/// </summary>
namespace MyatN_HW1
{
    static class Setup
    {
        /// <summary>
        /// Introduce the game name
        /// </summary>
        public static void Welcome()
        {
            //leave it black
            Console.BackgroundColor = ConsoleColor.Black;

            RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                           "~        Welcome to Mystical Grotton        ~ " +
                         "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

            
            //Console.WriteLine("\n__________________________________________\n");
        }
        /// <summary>
        /// Tell player how to play the game
        /// </summary>
        public static void Rules()
        {
            // Section to setup initial storyline
            //change font color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //•	Provide instructions for how to play the game
            Console.WriteLine("\tMystical Grotto is an interactive text based game. During\n" +
                               "the game you will be asked for decisions and to enter input. You\n" +
                               "will be provided with all that you need to know as you play the\n" +
                               "game and will only require a keyboard to play. Enjoy the adventure!\n");
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
            Setup.ColorChange(10, name = Console.ReadLine().Trim());
            do
            {
                //user press 'enter'
                if (string.IsNullOrEmpty(name))
                {
                    //will loop again and ask for valid name
                    valid = false;
                    Console.WriteLine("Sorry, you have not inputted a name. Please input a valid name!");
                    Setup.ColorChange(10, name = Console.ReadLine().Trim());
                }
                else
                {
                    //exits loop
                    valid = true;
                }
            }
            while (valid == false);
            return name;
        }
        /// <summary>
        /// Get 'Y'es or 'N'o to play the game or not 
        /// </summary>
        /// <returns></returns>
        public static void PlayGame(string name)
        {
            //Variables
            string playGame;

            //Greetings
            //•	Provide the initial narration, using the name provided by the user.
            Console.WriteLine("Nice to meet you {0}. I hope you are prepared to perish in a dark damp lair!\n", name);
            //•	Add a section inquiring if the user wants to start playing the game and asking for a Y/ N response.
            Console.WriteLine("Are you ready to play (Y/N)?");
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.White;
            Setup.ColorChange(10, playGame = Console.ReadLine().Trim().ToUpper()); //trim/toupper senitize userinput

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
                else
                {
                    Console.WriteLine("You braved yourself forward and decided to commence your adventure.");
                    Console.WriteLine("You have long since heard of rumors of the mysterious Mystical Grotto where no man has returned from. \n" +
                        "One day, you have decided to explore the outskirts of the Mansion in which the Mystical Grotto appeared in. \n" +
                        "You have reached the gates of the Mansion. Looking from outside, you see a lush garden. Despite the Mansion\n" +
                        "being abandoned for an indeterminate amount of time, it is surprisely kept.");
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
                Console.WriteLine("You braved yourself forward and decided to commence your adventure.");
                //nth code continues
            }
        }

        /// <summary>
        /// Create code to simulate dice rolls.You will need 2 random numbers
        /// and then add the 2 numbers together for the total.  
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int RollDice(int min, int max)
        {

            Random myrand = new Random();
            int rand1 = myrand.Next(min, max);
            int rand2 = myrand.Next(min, max);
            return rand1 + rand2;
        }
        public static int RollDie(int min, int max)
        {

            Random myrand = new Random();
            int rand = myrand.Next(min, max);
            return rand;
        }


        /// <summary>
        /// Prompt whether player wants to quit the game or continue
        /// 	If exiting the game, you must allow the game player to see all the messages on the screen that they lost before the window closes
        /// </summary>
        public static void Quit()
        {
            string response;
            Console.WriteLine("You are faced with a difficult decision.");
            Console.WriteLine("Do you wish to quit or continue? Enter 'Q' to quit or anything else to continue");
            Setup.ColorChange(10, response = Console.ReadLine().Trim().Substring(0).ToUpper()); //substring 0 allows for null
            if (string.IsNullOrEmpty(response)) //if user input is null meaning they press "Enter"
            {
                Console.WriteLine("You've decided to continue. Good Luck Adventurer!");

            }
            else
            {
                response = response.Substring(0, 1).ToUpper().Trim();//user senitize
                if (response != "Q")
                {
                    //code continues
                    Console.WriteLine("You've decided to continue. Good Luck Adventurer!");
                }
                else
                {
                    Console.WriteLine("Your persistence is pathetic. You have decided to quit adventuring.");
                    Environment.Exit(0);
                }
            }


        }
        /// <summary>
        /// Change color
        /// 1.) Blue
        /// 2.) Red
        /// 3.) DarkYellow
        /// 4.) Green
        /// 5.) Magenta
        /// 6.) DarkRed
        /// 7.) DarkGreen
        /// 8.) Yellow
        /// 9.) White
        /// 10.) Cyan
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static void ColorChange(int color, string message)
        {
            //variable
            switch (color)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 6:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 7:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 8:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 9:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(message);
                        break;
                    }
                case 10:
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                default:
                    {
                        Console.Write("oops");
                        break;
                    }

            }

        }
        public static void RandColor(string message)
        {
            int randColor;

            int i = 0;
            while (i < message.Length)
            {
                randColor = Setup.RollDie(1, 10);
                ColorChange(randColor, message.Substring(i, 1));
                i++;
            }
        }



        public static void GameEnd(string message)
        {

        }

        public static void Clear()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }


        //No methods beyond here
    }
}
