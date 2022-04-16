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
    abstract class AtomicFireballSkunk
    {
        //Variable
        //•	Create a private int attribute of attackSkill in your parent class (AtomicFireballSkunk in my example).
        private int attackSkill;

        public AtomicFireballSkunk(int attackSkill)
        {
            this.attackSkill = attackSkill;
        }
        public virtual void Attack()
        {
        }
        /// <summary>
        /// •	•	Create a parent class method called IsAttackSuccessful.  This will be used to determine if the attack is successful or failed.  Create this as a protected method that returns a Boolean.  that is abstract.  We will have our two creature classes that we chose to be children classes implement them.  
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsAttackSuccessful() 
        {
            Random rand = new Random();
            //roll a dice between 1 and 6 and look at the parent attackSkill 
            int randomNum = rand.Next(1, 7);
            bool success;
            if (attackSkill >= randomNum)
            {
                success = true;
            }
            else
            {
                success = false;
            }
            return success; 
        }
    }
}
