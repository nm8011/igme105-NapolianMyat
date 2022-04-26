using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// Project: Homework5
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
///•	Abstraction
///•	Inheritance
///•	Polymorphism
///•	Interfaces
/// </summary>
namespace MyatN_HW1
{
    class ChocolateAlligator : Iedible
    {
        //ATTRIBUTE
        private int numOfTeeth;

        //CONSTRUCTOR
        public ChocolateAlligator(int numOfTeeth)
        {
            this.numOfTeeth = numOfTeeth;
            Console.WriteLine("The alligator looks ancient and has {0} number of razorsharp teeth " +
                "with numerous scars", numOfTeeth);
        }
        //METHOD
        public static bool Attack()
        {
            bool dead = false;
            int randValue = Setup.randGen(1, 3);
            if(randValue == 1)
            {
                Console.WriteLine("The alligator charges at you and attacks you snapping you in half.");
                dead = true;
                Setup.GameEnd("D", null);
            }
            else
            {
                Console.WriteLine("The alligator charges at you but you manage to evade in time.");
            }

            return dead;
        }
    }
}
