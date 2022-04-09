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
    /// <summary>
    /// 1.	Create a separate class Warship class that inherits from the Ship class.
    /// </summary>
    class Warship : Ship
    {
        //VARIABLE
        //2.Add a number of guns attribute to the Warship class.
        private int numOfGun;

        //PROPERTY

        public int NumOfGun { get { return numOfGun; } }

        //CONSTRUCTOR
        /// <summary>
        /// 3.	Provide a parameterized constructor that has the three attributes for 
        /// the parent class and an addition one for the number of guns on the ship.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="maxSpeed"></param>
        /// <param name="numOfGun"></param>
        public Warship(string name, int weight, int maxSpeed, int numOfGun):base(name, weight, maxSpeed)
        {
            this.numOfGun = numOfGun;
        }
        /// <summary>
        /// 4.	 Override the ToString method to return a String containing the Warship’s information. 
        /// Use the parent class ToString method to get the three parent class attribute values.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString()+string.Format("\n\tNumber of Guns: {0}", numOfGun);
        }
        /// <summary>
        /// 5.	Add a Firing method that uses the number of guns attribute to print a message to the 
        /// console about how many guns are firing. For example: “Firing 7 guns.” This method returns 
        /// nothing and takes no parameters.
        /// </summary>
        public void Firing()
        {
            Console.WriteLine("Firing {0} guns.", numOfGun);
        }
    }
}
