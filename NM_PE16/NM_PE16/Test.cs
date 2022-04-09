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
    class Test
    {
        public static List<Ship>createShipList()
        {
            List<Ship> shipList = new List<Ship>();
            //a.	Creates a Ship, Warship, and Transport.
            Ship ship = new Ship("Titanic", 52310, 23);
            shipList.Add(ship);
            Warship warship = new Warship("Battalion", 10000, 25, 10);
            shipList.Add(warship);
            Transport transportShip = new Transport("Hermes", 220000, 15);
            shipList.Add(transportShip);
            return shipList;
        }
        static void Main(string[] args)
        {
            List<Ship> shipList = new List<Ship>();
            //a.	Creates a Ship, Warship, and Transport.
            Ship ship = new Ship("Titanic", 52310, 23);
            shipList.Add(ship);
            Warship warship = new Warship("Battalion", 10000, 25, 10);
            shipList.Add(warship);
            Transport transportShip = new Transport("Hermes", 220000, 15);
            shipList.Add(transportShip);


            //b.Lists the character data for each one using ToString
            //Console.WriteLine(ship.ToString());
            //Console.WriteLine(warship.ToString());
            //Console.WriteLine(transportShip.ToString());

            //TestPoly
            //TestPoly(warship);
            //TestPoly(transportShip);
            //TestPoly(ship);
            foreach (Ship ships in shipList)
            {
                TestPoly(ships);
            }


            //DESIGN
            //Create Ship with attributes name, weight(tons), maxSpeed
            //Create Warship class with attributes numOfGuns
        }
        /// <summary>
        /// c.	Has a single static method named TestPoly that takes a Ship as a parameter. 
        /// The method returns nothing. (This is important: the data type must be Ship, not 
        /// Warship or Transport.) The method does the following:
        /// </summary>
        public static void TestPoly(Ship shipPerimeter)
        {
            List<Ship> shipList = createShipList();
            //i.Calls ToString for the parameter passed in.
            Console.WriteLine(shipPerimeter.ToString());

            //ii.	If the parameter is actually a Warship, casts it to be a Warship
            //and calls the Firing method
            string name = shipPerimeter.Name;
            if (shipPerimeter is Warship)
            {
                Warship w = (Warship)shipPerimeter;
                Console.WriteLine("The {0} is a warship.", name);
                w.Firing();
            }
            else if (shipPerimeter is Transport)
            {
                Transport t = (Transport)shipPerimeter;
                Console.WriteLine("The {0} is a Transport Ship.", name);
            }
            else if (shipPerimeter is Ship)
            {
                Console.WriteLine("The {0} is a Ship.", name);
            }
            else
            {
                Console.WriteLine("This is not a ship.");
            }
        }
    }
}
