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
    class Class
    {
        //VARIABLES - •	Use the protected access modifier for the three common attributes. 
        private string name;
        protected int strength;
        protected int dex;
        protected int intelligence;
        //CONSTRUCTOR
        /// <summary>
        /// •	Create a parent class with a parameterized constructor that takes the three 
        /// common attributes and the character’s names as arguments.
        /// </summary>
        /// <param name="strength"></param>
        /// <param name="dex"></param>
        /// <param name="intelligence"></param>
        /// <param name="name"></param>
        public Class(int strength, int dex, int intelligence, string name)
        {
            this.strength = strength;
            this.dex = dex;
            this.intelligence = intelligence;
            this.name = name;
        }
        public int Strength { get { return strength; } set { strength = value; } }
        public int Dex { get { return dex; } set { dex = value; } }
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }



        //PROPERTIES
        /// <summary>
        /// 	Make the name private and provide an accessor
        /// You can assume the character’s name won’t change during the game
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// •	Create a toString method that returns a String 
        /// containing the character’s information.
        /// </summary>
        /// <returns></returns>
        public virtual string Tostring(string classType)
        {
            string toString = string.Format("Character Info\n" +
                "\tCharacter: {0}\n" +
                "\tClass Type: {4}\n" +
                "\tStrength: {1}\n" +
                "\tDex: {2}\n" +
                "\tIntelligence: {3}\n", this.name, this.strength, this.dex, this.intelligence, classType);
            return toString;
        }
        /// <summary>
        /// •	Create a method to change the intelligence value. The value will be 
        /// added to the current intelligence. (Negative values lower intelligence, 
        /// positive ones improve it.)
        /// </summary>
        /// <param name="intelligence"></param>
        /// <returns></returns>
        public virtual void changeIntelligenceValue(int intelligence)
        {
            this.intelligence = this.intelligence + intelligence;
        }
    }
}
