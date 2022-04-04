using System;
using System.Collections.Generic;
using System.Text;

namespace NM_PE15
{
    /// <summary>
    /// •	Create a parent class with a parameterized constructor that 
    /// takes the three common attributes and the character’s names as arguments.
    /// </summary>
    class Class
    {
        //VARIABLES - •	Use the protected access modifier for the three common attributes. 
        private string name;
        protected int health;
        protected int dmg;
        protected int armour;
        //CONSTRUCTOR
        public Class(int health, int dmg, int armour, string name)
        {
            this.health = health;
            this.dmg = dmg;
            this.armour = armour;
            this.name = name;
        }
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
        public virtual string ToString()
        {
            string toString = string.Format("Character Info\n" +
                "\tCharacter: {0}\n" +
                "\tHealth: {1}\n" +
                "\tDamage: {2}\n" +
                "\tArmour: {3}\n", this.name, this.health, this.dmg, this.armour);
            return toString;
        }
    }
}
