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
    static class Yard
    {
        /// <summary>
        /// User arrive to door of house
        /// </summary>
        /// <param name="numOfSteps"></param>
        public static void GetToDoor(int numOfSteps)
        {
            //Ask the user for how many steps to move.
            Console.WriteLine("\nHow many steps are you going to move?");
            //Read the user step input in and convert it to an integer
            int userNumOfSteps = 0;
            bool valid = false; //reset to false
            string response = Console.ReadLine().Trim();
            do
            {
                valid = int.TryParse(response, out int result);//takes response and try to parse to int

                if (valid == false)//if cannot, ask again
                {
                    Console.WriteLine("You have not inputted a valid number of steps, please try again.");
                    response = Console.ReadLine().Trim();
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
    }
}
