using System;
/// <summary>
/// Napolian Myat
/// 04/06/2022
/// Professor Warren
/// Project: PE16 - Polymorphism 
/// Purpose: Based on Feudal board game interface
/// </summary>
namespace NM_PE17
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
