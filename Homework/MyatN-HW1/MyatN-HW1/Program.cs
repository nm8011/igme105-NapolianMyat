using System;
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
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string name;    //save user name
            string playGame;    //whether to play game or not
            //Create a constant value for the number of steps required to get from the driveway to the house.
            //(You can select your own positive integer value as the total number of steps as long as it is less than 100).
            const int numOfSteps = 50;
            int userAnsNum;
            int calcNum; //calculations to show the user how far they would have walked past the house and notify them you stopped at the door.    

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Introduction
            //•	Provide the name of the game
            //•	Provide instructions for how to play the game
            //leave it black
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome to Morg's Diabetic Sugar Adventure");
            Console.WriteLine("__________________________________________\n");


            // User starts here – ask for basic information such as user name.
            //•	Ask the user for their name, read it in and save it (It is used multiple times throughout the game)
            Console.Write("Please enter your character name: ");
            name = Console.ReadLine();

            //Greetings
            //•	Provide the initial narration, using the name provided by the user.
            //change font color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Nice to meet you, " + name + " I hope you are prepared to die in a sugar coma!\n");

            // Section to setup initial storyline
            //•	Provide instructions for how to play the game
            Console.WriteLine(" Morg's Diabetic Sugar Adventure is an interactive text based game.\nDuring the game you will" +
                " be asked for decisions and to enter input.\nYou will be provided with all that you need to know as you play " +
                "the game\nand only need a keyboard to play.  Enjoy the adventure!\n");
            Console.ForegroundColor = ConsoleColor.White;
            //change color back

            //•	Add a section inquiring if the user wants to start playing the game and asking for a Y/ N response.
            Console.WriteLine("Are you ready to play (Y/N)?");
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.White;
            playGame = Console.ReadLine().Trim().ToUpper(); //trim/toupper senitize userinput

            //In case player enters yes or no instead of y or n
            if (playGame == "YES" || playGame == "NO")
            {
                Console.WriteLine("\n*sigh*.... we asked for a 'Y' or an 'N'");
                if (playGame == "NO")
                {
                    Console.WriteLine("\nYou have decided you are not ready to play the game.\nCome again when you are ready. :)");
                }
                playGame = playGame.Substring(0, 1);


            }
            //test
            //Console.WriteLine(playGame);

            if (playGame != "Y")
            {
                //They gave us anything BUT Y
                return;
            }
            else
            {
                //Ask the user for how many steps to move.
                Console.WriteLine("\nHow many steps are you going to move?");
                //Read the user step input in and convert it to an integer
                userAnsNum = int.Parse(Console.ReadLine());

                //Calculations for over and under the number of required steps created and used in output. 
                calcNum = Math.Abs(numOfSteps - userAnsNum);


                //user input is greater
                if (userAnsNum > numOfSteps)
                {
                    Console.WriteLine("You would have walked past the door by {0} steps. You have stopped at the door.", calcNum);
                }
                //user input less than
                else if (userAnsNum < numOfSteps)
                {
                    Console.WriteLine("You are short of {0} steps. I have increased your steps. Now you are at the door.", calcNum);
                }
                //userinput == const
                else
                {
                    Console.WriteLine("You are right on the mark! You have arrived at the door.");
                }
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
