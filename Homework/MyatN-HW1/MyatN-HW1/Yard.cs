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
    static class Yard
    {
        /// <summary>
        /// Before entering the door, reach the gates
        /// </summary>
       

        /// <summary>
        /// User arrive to door of house
        /// </summary>
        /// <param name="numOfSteps"></param>
        public static void GetToDoor(int numOfSteps)
        {
            //Ask the user for how many steps to move.
            Console.WriteLine("\nTo proceed, you must absolve yourself and move your legs. How many steps are you going to move?");
            //Read the user step input in and convert it to an integer
            int userNumOfSteps = 0;
            bool valid = false; //reset to false
            string response;
            Setup.UserInput(response = Console.ReadLine().Trim());
            do
            {
                valid = int.TryParse(response, out int result);//takes response and try to parse to int

                if (valid == false)//if cannot, ask again
                {
                    Console.WriteLine("You have not inputted a valid number of steps, please try again.");
                    Setup.UserInput(response = Console.ReadLine().Trim());
                }
                else// if can, take the value
                {
                    userNumOfSteps = int.Parse(response);
                    valid = true;
                    //nth
                }
            }
            while (valid == false);

            //Calculations for over and under the number of required steps created and used in output. 
            int calcNum = Math.Abs(numOfSteps - userNumOfSteps);

            //user input is greater
            if (userNumOfSteps > numOfSteps)
            {
                Console.WriteLine("You would have walked past the door by {0} steps. You have stopped at the door.", calcNum);
            }
            //user input less than
            else if (userNumOfSteps < numOfSteps)
            {
                Console.WriteLine("You are short of {0} steps. I have increased your steps. Now you are at the door.", calcNum);
            }
            //userinput == const
            else
            {
                Console.WriteLine("You are right on the mark! You have arrived at the door.");
            }
        }
        /// <summary>
        /// o	Add a note to the front door that it is locked and needs a key.
        /// 	Incorporate the player name in the door note.  
        /// </summary>
        /// <param name="name"></param>
        public static void Note(string name)
        {
            Console.WriteLine("Hello, {0}. The door is currently locked and can only be opened with a key.", name);
        }

        /// <summary>
        /// 	If exiting the game, you must allow the game player to see all the messages on the screen that they lost before the window closes.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diceRoll"></param>
        public static void DeathDoor(string name, int diceRoll, int deathDoor)
        {
            if (diceRoll > deathDoor)
            {
                Console.WriteLine("{0} rolled a {1}. Lady Luck shines upon you, the door somehow magically opened for you.", name, diceRoll);
                //continues
            }
            else
            {
                Console.Clear();
                Console.WriteLine("{0} rolled a {1}. After numerous attempts to picklock the door.\n" +
                    "Sensing your vain stubborn efforts, as if to mock you the mysterious entity behind the door exploded the doors\n" +
                    "blasting you to oblivion. You have died. Game over!", name, diceRoll);
                Environment.Exit(0);
            }
        }

    }
}
