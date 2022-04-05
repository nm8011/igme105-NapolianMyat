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
    class Thief : Class
    {
        //VARIABLE
        //A measure of the number of times a thief fails at a heist.
        //This value would become smaller as the character gains experience.
        protected int oopsFactor;

        //CONSTRUCTOR
        public Thief(int strength, int dex, int intelligence, string name, int oopsFactor): base(strength, dex, intelligence, name)
        {
            this.oopsFactor = oopsFactor;
        }
        public int OopsFactor { get { return oopsFactor; } }

        /// <summary>
        /// •	Override the toString method so that the output includes both the parent 
        /// class data and the data specific to this type of character (including the unique attribute).
        /// </summary>
        /// <param name="classType"></param>
        /// <returns></returns>
        public override string Tostring(string classType)
        {
            string text = string.Format("\tOopsFactor: {0}", oopsFactor);
            return base.Tostring(classType) + text;
        }
        public override void changeIntelligenceValue(int intelligence)
        {
            base.changeIntelligenceValue(intelligence);
            this.strength = strength * intelligence / 4;
            this.dex = dex * (15 / intelligence);
        }
    }
}
