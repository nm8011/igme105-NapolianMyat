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
    class Program
    {

        static void Main(string[] args)
        {
            //Variables
            string name;    //save user name
            //Create a constant value for the number of steps required to get from the driveway to the house.
            //(You can select your own positive integer value as the total number of steps as long as it is less than 100).
            const int numOfSteps = 50;
            //Random
            int diceRoll;
            int deathDoor = 1; //made it 1 so debugging is not so annoying, suppose to be 4
            string text;
            bool success;

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Basic Info - HW1
            Setup.Welcome(); //Welcome the user
            name = Setup.GetName(); //Ask for user name

            Setup.Rules(); //Explain the rules

            Setup.PlayGame(name); //Ask whether to play the game or not

            Yard.GetToDoor(numOfSteps); //const num of steps to door

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Arrive at door - HW2
            //	Incorporate the player name in the door note.  
            Yard.Note(name);


            //check diceRoll
            //  *x>4, door opens
            //  *x<=4 player dies
            //if door opens, can proceed, otherwise die
            success = Yard.FrontDoor(name, deathDoor);
            if (success == true)
            {
                Yard.FrontDoorChallenge();
                Setup.GameEnd("Q", null);
                Setup.PressToClear(true);
            }
            else
            {
                Setup.GameEnd("D", null);

            }

            Mansion.UpperFloor();

            Grotto.DungeonFloors();

            
            





            // What is the flow?
            // path to front door
            // challenge to get in front door
            // what do you see when get in the door?
            // User finds the dungeon door and escapes with the Hershey Candy Golden Globes

        }
        //Hopefully works
        //NO CODE OUTSIDE HERE
    }
}



