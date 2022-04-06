using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// PE15 - Inheritance
/// Professor. Warren
/// 04/04/2022
/// </summary>
namespace NM_PE15
{
    /// <summary>
    /// •	Create a separate class for each character type. This class will 
    /// have a parameterized constructor that gets all the character data.
    /// </summary>
    class Warrior : Class
    {
        //VARIABLE
        //Tracks the odor level of the character. The worse it is, the less likely
        //they are to find people to team up with them. Taking a bath resets this number.
        protected int daysLastBath;

        //CONSTRUCTOR
        public Warrior(int strength, int dex, int intelligence, string name, int daysLastBath) : base(strength, dex, intelligence, name)
        {
            this.daysLastBath = daysLastBath;
        }

        public int DaysLastBath { get { return daysLastBath; } }

        /// <summary>
        /// •	Override the toString method so that the output includes both the parent 
        /// class data and the data specific to this type of character (including the unique attribute).
        /// </summary>
        /// <param name="classType"></param>
        /// <returns></returns>
        public override string Tostring(string classType)
        {
            string text = string.Format("\tDaysSinceLastBath: {0}", daysLastBath);
            return base.Tostring(classType) + text;
        }
        public override void changeIntelligenceValue(int intelligence)
        {
            base.changeIntelligenceValue(intelligence);
            this.strength = strength * intelligence/2;
            this.dex = dex * (30 / intelligence);
        }
    }
}
