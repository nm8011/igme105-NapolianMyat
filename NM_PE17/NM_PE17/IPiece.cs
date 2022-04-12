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
    /// 1.	Create an interface called IPiece that defines the properties and methods 
    /// that a piece in this game would require.  Ideally, a piece would be able to 
    /// move around by altering its row and/or column.  It would also need a way to 
    /// get and set whether it is currently alive or not.
    /// </summary>
    interface IPiece
    {
        //VARIABLE
        /// <summary>
        /// It would also need a way to get and set whether it is currently alive or not.
        /// </summary>
        //public bool IsAlive
        //{
        //    get { return IsAliveMethod();}
        //    set { IsAlive = value; }
        //}

        public static bool IsAliveMethod()
        {
            bool isAlive = true;
            return isAlive;
        }
        /// <summary>
        /// UDLR(up, down, left right)
        /// move direction = Vert
        /// </summary>
        /// <param name="moveUDLR"></param>
        /// <param name="xCord"></param>
        /// <param name="yCord"></param>
        /// <param name="moveDirection"></param>
        /// <returns></returns>
        public static int Move(string moveDir, int moveXCord)
        {
            King king = new King(12,12);

            //int[] xyCord = new int[] { xCord, yCord };
            //if (moveDirection == "Vert")
            //{
            //    Console.WriteLine("Moved {0} by {1} spaces: {2} at position ({3},{4}), Is Alive: {5}"
            //        , xCord);

            //}
            //else if (moveDirection == "Hori")
            //{ 
            //}
            //else if(moveDirection == "Diag")
            //{ 
            //}
            //Console.WriteLine("Moved {0} by {1} spaces: {2} at position ({3},{4}), Is Alive: {5}", );
            return 0;
        }
    }
}
