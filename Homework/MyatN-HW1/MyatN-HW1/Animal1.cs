using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// Project: Homework3
/// Date: 01/31/2022
/// Modified: 03/02/2022
/// Purpose: Extension of hw1
/// For this homework, we will begin creating our Text Adventure using:
///•	Random class
///•	string and math class methods
///•	If Statements and Relational\ Boolean Operators
///•	Nested If Statements
///•	Switch Statements
///•	Loops
///•	Method Overloading / Variable Scope
///•	Method parameters returning Values
///•	Classes
/// </summary>
namespace MyatN_HW1
{
    static class Animal1
    {
        public static void SphinxRiddle()
        {
            string answer;
            bool correct = false;
            Console.WriteLine("The Sphinx has a riddle for you. If you solve it correctly you can continue\n" +
                "forward. However, answer wrongly, you will be doomed. The riddle is:\n\t\t");
            do
            {
                Console.WriteLine("What can bring back the dead; make you cry, make you laugh, make you young;\n\t" +
                "is born in an instant, yet lasts a lifetime.\n" +
                "A.) Love\n" +
                "B.) Memory\n" +
                "C.) Desire");
                answer = Setup.UserInput().ToUpper();
                switch (answer)
                {
                    case "A":
                        {
                            Console.WriteLine("Wrong! Love can make you cry, make you laugh, make you feel young, can be \n" +
                                "born in an instant, can last a lifetime. However, it cannot bring back\n" +
                                "the dead. ");
                            Setup.GameEnd("D", "The Sphinx finds you to be appetizing. He has devoured you.");

                            break;
                        }
                    case "B":
                        {
                            Console.WriteLine("Correct! People can live on in memories, can last a lifetime, make you young, laugh,\n" +
                                "cry, and be born in an instant. The Sphinx laments at you getting it correct.\n" +
                                "You are allowed to pass.");
                            correct = true;
                            break;
                        }
                    case "C":
                        {
                            Console.WriteLine("Not even remotely close");
                            Setup.GameEnd("D", "The Sphinx finds you to be appetizing. He has devoured you.");
                            break;
                        }
                    default:
                        {
                            Setup.ColorChange(3,"That is not an option");
                            correct = false;//loops back
                            break;
                        }
                }
            }
            while (correct != true);
        }
    }
}
