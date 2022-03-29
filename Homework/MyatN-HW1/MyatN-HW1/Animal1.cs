using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// Project: Homework4
/// Date: 01/31/2022
/// Modified: 03/29/2022
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
///•	Class Properties
///•	Arrays
///•	Lists and Dictionaries
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
                "forward. However, answer wrongly, you will be doomed. The riddle is:\n");
            Setup.ColorChange(3, "\t ______________________________________________________________\n" +
                    "\t|                                                              |\n" +
                    "\t|\tWhat can bring back the dead; make you cry, make you   |\n" +
                    "\t|\tyoung; is born in an instant, yet lasts a lifetime.    |\n" +
                    "\t|\t    A.) Love                                           |\n" +
                    "\t|\t    B.) Memory                                         |\n" +
                    "\t|\t    C.) Desire                                         |\n" +
                    "\t|\t                                                       |\n" +
                    "\t|______________________________________________________________|\n");
            do
            {

                Console.Write(">");
                answer = Setup.UserInput().ToUpper();
                switch (answer)
                {
                    case "A":
                        {
                            Console.WriteLine("Wrong! Love can make you cry, make you laugh, make you feel young, can be \n" +
                                "born in an instant, can last a lifetime. However, it cannot bring back\n" +
                                "the dead. ");
                            Setup.GameEnd("D", "The Sphinx finds you to be appetizing. He has devoured you.\n" +
                                "Since you are so adament that love can bring back the dead,\n" +
                                "maybe love will bring you back. Most likely not."); //death

                            break;
                        }
                    case "B":
                        {
                            Setup.ColorChange(4,"Correct! People can live on in memories, can last a lifetime, make you young, laugh,\n" +
                                "cry, and be born in an instant. The Sphinx laments at you getting it correct.\n" +
                                "You are allowed to pass.\n");
                            correct = true; //loops back, dragon ask for something else
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
                            Setup.ColorChange(6,"That is not an option\n");
                            correct = false;//loops back
                            break;
                        }
                }
            }
            while (correct != true);

        }
    }
}
