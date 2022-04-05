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
    class Wizard : Class
    {
        //VARIABLE
        //Tracks the percent of time a spell backfires on a wizard. Some backfires
        //don’t do any damage, but if you accidentally turn your entire party into toads,
        //you can assume they will not be too happy. This value would become smaller as
        //the character gains experience.
        protected int backfirePercentage;

        //CONSTRUCTOR
        public Wizard(int strength, int dex, int intelligence, string name, int backfirePercentage) : base(strength, dex, intelligence, name)
        {
            this.backfirePercentage = backfirePercentage;
        }
        public int BackfirePercentage { get { return backfirePercentage; } }

        /// <summary>
        /// •	Override the toString method so that the output includes both the parent 
        /// class data and the data specific to this type of character (including the unique attribute).
        /// </summary>
        /// <param name="classType"></param>
        /// <returns></returns>
        /// <summary>
        /// •	Override the toString method so that the output includes both the parent 
        /// class data and the data specific to this type of character (including the unique attribute).
        /// </summary>
        /// <param name="classType"></param>
        /// <returns></returns>
        public override string Tostring(string classType)
        {
            string text = string.Format("\tBackFirePercentage: {0}", backfirePercentage);
            return base.Tostring(classType) + text;
        }
        public override void changeIntelligenceValue(int intelligence)
        {
            base.changeIntelligenceValue(intelligence);
            this.strength = strength * intelligence / 6;
            this.dex = dex * (50 / intelligence);
        }
    }
}
