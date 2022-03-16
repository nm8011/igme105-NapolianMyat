﻿using System;
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
        /// User arrive to door of house
        /// </summary>
        /// <param name="numOfSteps"></param>
        public static void GetToDoor(int numOfSteps)
        {
            //Ask the user for how many steps to move.
            Setup.RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                             "~                     Yard                  ~\n" +
                             "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Setup.ColorChange(3, "\tYou have long since heard rumors of the mysterious Mystical Grotto where no man has returned from. \n" +
                    "One day, you have decided to explore the outskirts of the Mansion in which the Mystical Grotto appeared in. \n" +
                    "You have reached the gates of the Mansion. Looking from outside, you see a lush garden. Despite the Mansion\n" +
                    "being abandoned for an indeterminate amount of time, it is surprisely kept. You feel a compelling force to\n" +
                    "enter.");
            Console.Write("\n\nTo proceed, you must absolve yourself and move your legs. How many steps are you going to move?\n>");
            //Read the user step input in and convert it to an integer
            int userNumOfSteps = 0;
            string response;

            response = Setup.UserInput();
            userNumOfSteps = Setup.UserIntValidation(response, "Please enter an integer");

            //Calculations for over and under the number of required steps created and used in output. 
            int steps = userNumOfSteps;
            int remainingSteps = Math.Abs(numOfSteps - steps);


            //user input is greater
            if (steps > numOfSteps)
            {
                Console.WriteLine("You would have walked past the door by {0} steps if you had kept going. \n" +
                    "You have stopped at the door.", remainingSteps);
            }
            //user input less than
            else if (steps < numOfSteps)
            {
                while (steps < numOfSteps)
                {
                    Console.WriteLine("You are short of steps. You have not reached the Mansion yet. No rush. You are enjoying the \n" +
                        "environment around the Mansion which is pristine and serene.\n" +
                    "How many more steps will you take?\n>");
                    response = Setup.UserInput();
                    userNumOfSteps = Setup.UserIntValidation(response, "Please enter an integer");
                    steps = steps + userNumOfSteps;
                    remainingSteps = Math.Abs(numOfSteps - steps);
                }
                Console.WriteLine("You would have walked past the door by {0} steps if you had kept going. \n" +
                    "You have stopped at the door.", remainingSteps);
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
            Console.WriteLine("\nGreetings, {0}. The door is currently locked and can only be opened with a key.\n" +
                              "For some reason there is also a slot machine near the entryway. You also noticed " +
                              "\nthere is a note at the door. You read it, it says: "
                , name);

            Setup.ColorChange(3,"\n\t\tWelcome, adventurer. As you have probably noticed, the door is currently lock." +
                                "\n\tFortune favours the bold. The only known method of unlocking the door is rolling" +
                                "\n\tthe slot machine locating next to the door. If you roll unluckily, you will perish." +
                                "\n\tIf you roll luckily, the key will pop out. You will be leaving your fate... up to fate.\n\n");
            Setup.PressToClear(false);
        }

        /// <summary>
        /// 	If exiting the game, you must allow the game player to see all the messages on the screen that they lost before the window closes.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diceRoll"></param>
        public static bool FrontDoor(string name, int deathDoor)
        {
            string text;
            bool success;
            int diceRoll;
            //o	Create code to simulate dice rolls.  
            //roll 2 dice
            diceRoll = Setup.RollDice(1, 7); //to get 2 dice roll of 1-6 added together
            if (diceRoll > deathDoor)
            {
                success = true;
                text = string.Format("\n{0} rolled a {1}. The bare minimum roll is {2}. Lady Luck shines upon you, \n" +
                                  "the slot machine delivers the key in a pod to you.\n"
                                  , name, diceRoll, deathDoor);
                Setup.ColorChange(4, text);
                FrontDoorChallenge();
                Setup.GameEnd("Q", null);
                Setup.PressToClear(true);
                //continues
            }
            else
            {
                success = false;
                text = string.Format("\n{0} rolled a {1}. The bare minimum roll is {2}. You failed to roll the bare minimum, you did not" +
                                  "\nget the key. You then resorted to picklocking. After numerous attempts to picklock the door." +
                                  "\nSensing your vain stubborn efforts, as if to mock you the mysterious entity behind the Grotto " +
                                  "\nexploded the doors blasting you to oblivion.\n"
                                  , name, diceRoll, deathDoor);
                Setup.GameEnd("D", text);
            }
            return success;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void FrontDoorChallenge()
        {
            string choice;
            bool success = false;
            Console.WriteLine("\nBefore you could open the door, 2 fabled creatures appeared before you from\n" +
                "seemingly nowhere. They prompt you to choose one of them to access the door.\n" +
                "Did you think it was going to be that easy? Which will you choose?" +
                "\n\tA.) The Sphinx" +
                "\n\tB.) The Dragon");
            do
            {
                choice = Setup.UserInput().ToUpper();
                switch(choice)
                {
                    case "A":
                        {
                            Animal1.SphinxRiddle();
                            success = true;
                            break;
                        }
                    case "B":
                        {
                            Animal2.DragonWish();
                            success = true;
                            break;
                        }
                    default:
                        {
                            Setup.ColorChange(3,"That is not an option");
                            success = false;
                            break;
                        }
                }
            }
            while (success != true);
        }


    }
}
