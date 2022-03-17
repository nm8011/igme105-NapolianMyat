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
    static class Animal2
    {
        public static void DragonWish()
        {
            bool correct = false;
            string response;
            Console.Write("The Dragon desires something of your possession. He demands you give it to him.\n" +
                "What could it be? What will you give him?\n\t" +
                "A.) The 5 cent in your pocket\n\t" +
                "B.) Your math homework\n\t" +
                "C.) The slimjim in your jacket\n>");
            do
            {
                response = Setup.UserInput().ToUpper().Substring(0,1);
                switch(response)
                {
                    case "A":
                        {
                            Console.WriteLine("Thats correct! All dragons innately desire treasures and wealth\n" +
                                "5 cent is still wealth. What a cheap dragon, wont even let you keep it.");
                            correct = true;
                            break;
                        }
                    case "B":
                        {
                            Setup.GameEnd("D", "The dragon is enraged. It thinks you're mocking him. In it's fury it slashes at you.");
                            break;
                        }
                    case "C":
                        {
                            Console.Write("The dragon muses at your kindness. Although the dragon enjoys slimjims for bedtime snacks,\n" +
                                "It is not hungry at the moment. It desires something else. What will you give him?\n>");
                            correct = false;
                            break;
                        }
                    default:
                        {
                            Setup.ColorChange(6, "That is not an option!\n");
                            correct = false;//loops back
                            break;
                        }
                }
            }
            while (correct != true);
            Setup.PressToClear(true);

        }
    }
}
