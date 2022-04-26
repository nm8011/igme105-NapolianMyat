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
    class RedSkunk:AtomicFireballSkunk
    {
        //•	Create a constant for skill level in each child class and set the
        //attribute between 1 and 5 for difficulty of the creature.
        private const int SKILL_LEVEL = 1;
        /// <summary>
        /// •	We need to let the parent class know about our skill level of the child.  
        /// We created the constructor in the parent class to allow this, now we need 
        /// the child class to call the parent class constructor. We will need to use 
        /// the base keyword here to access the parent constructor.
        /// </summary>
        public RedSkunk():base(SKILL_LEVEL)
        {
        }

        public override bool Attack()
        {
            bool success;
            //	A call to the parent IsAttackSuccesfull method.
            success = IsAttackSuccessful();
            //Based on the result create an if statement that returns text to the adventurer.  
            //.    If the result from our method call is true, the attack succeeded, we die
            //and the game is over.  Otherwise it failed and we continue with our game.    
            if (success == true)
            {
                Console.WriteLine("Attack was successful");
                Console.WriteLine("Red Skunk throws fireball killing you");
            }
            else 
            { 
                Console.WriteLine("Attack was not successful");
            }
            return success;
        }
    }
}
