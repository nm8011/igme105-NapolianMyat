﻿using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// Project: Homework4
/// Date: 01/31/2022
/// Modified: 03/29/2022
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
///•	Class Properties
///•	Arrays
///•	Lists and Dictionaries
/// </summary>
namespace MyatN_HW1
{
    class Program
    {

        static void Main(string[] args)
        {
            //VARIABLE
            bool dead = false;
            //•	Create List in main program class
            List<string> userItemsList = new List<string>();
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            while (dead != true)
            {
                Setup.Welcome(); //welcome the user
                Setup.GetName(); //ask for user name
                Setup.Rules(); //Explain the rules
                Setup.DifficultyLevel();
                Setup.PlayGame(); //Ask whether to play the game or not
                Setup.GettingInformation(1, 20);
                userItemsList = Setup.UserFoodList(userItemsList, 3);//3min number of input
                Yard.GetToDoor(); //const num of steps to door
                Yard.Note(); //Incorporate the player name in the door note.  
                dead = Yard.FrontDoor();
                dead = Mansion.UpperFloor();
                dead = Grotto.DungeonFloors();
            }

            //int i = 0;
            //while (dead != true)
            //{
            //    dead = Setup.Dead;
            //    switch (i++)
            //    {
            //        case 0:
            //            {
            //                Setup.Welcome(); //welcome the user
            //                Setup.GetName(); //ask for user name
            //                Setup.Rules(); //Explain the rules
            //                Setup.PlayGame(); //Ask whether to play the game or not
            //                break;
            //            }
            //        case 1:
            //            {
            //                Yard.GetToDoor(); //const num of steps to door
            //                Yard.Note(); //Incorporate the player name in the door note.  
            //                dead = Yard.FrontDoor();
            //                break;
            //            }
            //        case 2:
            //            {
            //                dead = Mansion.UpperFloor();
            //                break;
            //            }
            //        case 3:
            //            {
            //                dead = Grotto.DungeonFloors();
            //                break;
            //            }
            //        default:
            //            {
            //                Environment.Exit(0);
            //                break;
            //            }
            //    }
            //    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //}
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



