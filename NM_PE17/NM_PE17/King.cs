using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// 04/06/2022
/// Professor Warren
/// Project: PE17 - Polymorphism 
/// Purpose: Based on Feudal board game interface
/// I did not do what was asked I'm sorry but I didnt have time to figure it out due to my time negligence
/// </summary>
namespace NM_PE17
{
    /// <summary>
    /// 2.	Create a King class that implements the IPiece interface. A King can move 
    /// 1 or 2 spaces horizontally, vertically, or diagonally.  Be sure to implement 
    /// everything from IPiece, and create any additional attributes, constructors and 
    /// methods you may need (for instance, a ToString).
    /// </summary>
    class King : IPiece
    {
        //VARIABLE
        private bool isAlive = IPiece.IsAliveMethod();
        //a.	Think about what attributes a King would need to represent its position
        //on the board, and how they interact with the Move method.
        private int xCord;
        private int yCord;

        //PROPERTIES
        public int XCord
        {
            get { return xCord; }
            set { xCord = value; }
        }
        public int YCord
        {
            get { return yCord; }
            set { yCord = value; }
        }
        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = IPiece.IsAliveMethod(); }
        }

        public King(int xCord, int yCord)
        {
            this.xCord = xCord;
            this.yCord = yCord;
        }


    }
}
