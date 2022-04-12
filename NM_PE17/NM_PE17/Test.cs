using System;
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
    class Test
    {
        static void Main(string[] args)
        {
            //VARIABLES
            string pieceType = "King";
            //a.	Creates a King at position 12,12 (row,column).
            King king = new King(12, 12);
            bool isAlive = king.IsAlive;
            int moveXCord = 0;
            int moveYCord = 0;
            string moveDir;
            bool moveDiag = false;

            //Print something after each step!
            Console.WriteLine("Created {0}: {0} at position ({1},{2}), Is Alive: {3}"
                , pieceType, king.XCord, king.YCord, isAlive);

            //IDK why moving up changes the xCord? SHouldnt it be ycord?
            moveXCord = 2;
            moveDir = "up";
            if(moveDir == "up")
            {
                moveXCord = -2;
            }
            king.XCord = king.XCord + moveXCord;

            //b.Moves the King vertically 2 spaces up. (Up means decreasing row numbers.)
            Console.WriteLine("Moved {0} by two spaces: {1} at position ({2},{3}), Is Alive: {4}"
                , moveDir, pieceType, king.XCord, king.YCord, isAlive);

            moveDir = "right";
            if(moveDir == "right")
            {
                moveYCord = 1;
            }
            if(moveDir == "left")
            {
                moveYCord = -1;
            }
            king.YCord = king.YCord + moveYCord;


            Console.WriteLine("Moved {0} one space: {1} at position ({2},{3}), Is Alive: {4}",
                moveDir, pieceType, king.XCord, king.YCord, isAlive);

            moveDiag = true;
            moveDir = "right";
            moveYCord = 2;
            king.YCord = king.YCord + moveYCord;

            if(moveDiag == true && (moveXCord >= 2 || moveYCord >= 2))
            {
                king.YCord = king.YCord - moveYCord;
                Console.WriteLine("Tried an illegal three space move: {0} at posiiton ({1},{2}), Is Alive: {3}",
                    pieceType, king.XCord, king.YCord, isAlive);
            }

            isAlive = false;
            Console.WriteLine("Killed by an archer: {0} at position ({1},{2}), Is Alive: {3}"
                ,pieceType, king.XCord, king.YCord, isAlive);

            Console.WriteLine("It's not always good to be the king.");


            /* Design:
             * Get num of players(2,4,6)
             * Board has 24 rows, 24 columns (x, y)
             *      If piece in contact - fight
             * Piece:
             *      Archer(pick off enemy unit up to 3 spaces away
             *      horizontally, vertically, or diagonally
             *      Other playing piece must be in contact to fight
             *      
             * Win if:
             *      Capture opponents' castle
             *      Wiping out all of opponents' royalty(King, Duke, Prince)
             */
        }
    }
}
