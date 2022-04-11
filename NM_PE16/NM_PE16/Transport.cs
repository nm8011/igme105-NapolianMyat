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
/// /// Questions:
/// 1.) The childclass(or object class) tostring is called
/// For ship, the parent class tostring is called, for warship is the warship 
/// tostring(which is the parent class tostring overridden to include it plus other aspect),
/// for transport is transport tostring
/// 2.) It can not find the method
/// 3.) No b/c the method doesnt exist in transport only in warship.
/// </summary>
namespace NM_PE16
{
    /// <summary>
    /// 1.	Create a separate class Transport class that inherits from the Ship class.
    /// </summary>
    class Transport : Ship
    {
        //VARIABLE
        //2.	Add a max cargo attribute to the Transport class.
        //This is the maximum weight of cargo the ship can carry.
        private double maxCargo;
        private const double Cargo_Percentage_Of_Weight = 0.4;

        //PROPERTY
        public double MaxCargo {get { return maxCargo; }}

        /// <summary>
        /// 3.	Provide a parameterized constructor that has the three attributes for the parent class. 
        /// The max cargo value will be 40% of the transport’s weight, so calculate the value in the 
        /// constructor and store it
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="maxSpeed"></param>
        /// <param name="maxCargo"></param>
        //CONSTRUCTOR
        public Transport(string name, int weight, int maxSpeed): base(name, weight, maxSpeed)
        {
            maxCargo = weight * Cargo_Percentage_Of_Weight;
        }
        /// <summary>
        /// Override the ToString method to return a String containing the Transport’s information. 
        /// Use the properties from the Ship class to get the three parent class attribute values.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string text = base.ToString() + string.Format("\n\tMax Cargo: {0} tons", maxCargo);
            return text;
        }
    }
}
