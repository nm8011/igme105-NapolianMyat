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
    class BlueSkunk:AtomicFireballSkunk
    {
        private const int skillLevel = 2;
        public BlueSkunk() : base(skillLevel)
        {
        }

        public override void Attack()
        {
            bool success;
            success = IsAttackSuccessful();
            if (success == true)
            {
                Console.WriteLine("Attack was successful");
                Console.WriteLine("Blue Skunk throws iceball killing you");
                Setup.GameEnd("D", "null");
            }
            else
            {
                Console.WriteLine("Attack was not successful");
            }
        }
    }
}
