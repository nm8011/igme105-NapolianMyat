using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// 04/08/2022
/// Professor Warren
/// Project: PE16
/// Purpose: We are going to examine the use of polymorphism. 
/// A Ship class will be defined. This class will be used as 
/// the parent of the Warship and Transport classes. We will 
/// then try to use polymorphism with some methods.
/// </summary>
namespace NM_PE16
{
    class Ship
    {
        //VARIABLES
        //2.	Make all three attributes private.
        private string name;
        private int weight;
        private int maxSpeed;

        //PROPERTIES
        //3. Provide properties for each attribute that allows a child class to get
        //their values. Do not allow changes to the attributes through the properties.
        public string Name { get { return name; }}
        public int Weight { get { return weight; } }
        public int MaxSpeed { get { return maxSpeed; } }



        //CONSTRUCTOR
        /// <summary>
        /// 1. Create a Ship class (this will be the parent) with a parameterized constructor 
        /// that takes a ship name, weight (in tons), and maximum speed (in knots) as parameters.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="maxSpeed"></param>
        public Ship(string name, int weight, int maxSpeed)
        {
            this.name = name;
            this.weight = weight;
            this.maxSpeed = maxSpeed;
        }
        /// <summary>
        /// 4.	Override the ToString method to return a String containing the ship’s information.
        /// </summary>
        /// <returns></returns>
        public virtual string ToString()
        {
            string text = string.Format("\nShip Details" +
                "\n\tShip Name: The {0}" +
                "\n\tWeight: {1} tons" +
                "\n\tMax Speed: {2} knots"
                , name, weight, maxSpeed);
            return text;
        }
    }
}
