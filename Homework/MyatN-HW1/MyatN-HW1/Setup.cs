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
        /// Introduce the game
        /// </summary>
        public static void Welcome()
        {
            //leave it black
            Console.BackgroundColor = ConsoleColor.Black;

            string welcome;
            int i = 0;
            welcome = "Welcome to Mystical Grotto";

            while (i < welcome.Length)
            {
                RandColor(welcome.Substring(i, 1));
                i++;
            }
            Console.WriteLine("\n__________________________________________\n");
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
            Setup.UserInput(name = Console.ReadLine().Trim());
            do
            {
                //user press 'enter'
                if (string.IsNullOrEmpty(name))
                {
                    //will loop again and ask for valid name
                    valid = false;
                    Console.WriteLine("Sorry, you have not inputted a name. Please input a valid name!");
                    Setup.UserInput(name = Console.ReadLine().Trim());
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
            Setup.UserInput(playGame = Console.ReadLine().Trim().ToUpper()); //trim/toupper senitize userinput

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
                Console.WriteLine("You have long since heard of rumors of the mysterious Mystical Grotto where no man has returned from. \n" +
                        "One day, you have decided to explore the outskirts of the Mansion in which the Mystical Grotto appeared in. \n" +
                        "You have reached the gates of the Mansion. Looking from outside, you see a lush garden. Despite the Mansion\n" +
                        "being abandoned for an indeterminate amount of time, it is surprisely kept.");
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
            Setup.UserInput(response = Console.ReadLine().Trim().Substring(0).ToUpper()); //substring 0 allows for null
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
        /// Will get color
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static void RandColor(string message)
        {
            //variable
            int color = Setup.RollDie(1,6);
            //string
            //int num = Setup.RollDice(1, 6);
            ////	Create a constant string with 8 colors separated by a comma
            //const string MY_COLORS = "Blue,Red,DarkYellow,Green,Magenta";
            //string tempword = MY_COLORS;
            //int find = MY_COLORS.IndexOf(",");
            //int i = 1;
            //while (i < num)
            //{
            //    find = tempword.IndexOf(",");
            //    tempword = tempword.Substring(find + 1, tempword.Length - find - 1);
            //    //test
            //    //Console.WriteLine(tempword);
            //    i++;
            //}
            //tempword = tempword.Substring(0, tempword.IndexOf(","));
            ////Console.WriteLine(tempword);
            //return tempword;

            switch(color)
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
                default:
                    {
                        Console.Write("oops");
                        break;
                    }
            }
            
        }

        /// <summary>
        /// Changes user input color to cyan
        /// </summary>
        /// <param name="message"></param>
        public static void UserInput(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;

        }


        public static void GameEnd(string message)
        {

        }

        //No methods beyond here
    }
}
