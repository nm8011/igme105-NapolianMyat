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
    static class Grotto
    {

        /// <summary>
        /// Having an authors block so story is not original yet. Will use this until I figure something more unique and interesting
        /// </summary>
        public static void DungeonFloors()
        {
            //Floor 1
            string response;
            bool exit = false;
            Console.WriteLine("As you enter the dungeon, you pushed the spider webs out of your way.\n" +
                "You look down and see that you are walking on marshlands-like environemnt. You see a \n" +
                "door across the way. but your feet has sunken into the marsh and you are immobilize.");

            Setup.Quit(); //ask if to quit before presenting what to do.
            Console.WriteLine("You have chosen not to quit. You begin to access the situation.");


            do
            {
                Console.WriteLine("\nYou look around and found the following in the room. \n\t1.) A rope is hanging from the ceiling.\n" +
                  "\t2.) A blow torch is sitting next to you. \n\t3.) A herb is right next to you\nWhat would you like to do?");
                Setup.ColorChange(10, response = Console.ReadLine().ToUpper().Trim());
                switch (response)
                {
                    case "1":
                        {
                            Console.WriteLine("You grabbed the rope and pulled yourself up, swinging across the marshland. Your shoes \nstayed stucked to the marshlands. You made it across the room safely though!");
                            exit = true;
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("You died because you picked the wrong option. Game over!");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not an option. Please select a valid option.");
                            exit = false;
                            break;
                        }
                }
            }
            while (exit == false);
            exit = false;
            //Floor 2

            Console.WriteLine("Wonderful, you made it off the marshmallows, just to find yourself staring at a chocolate fudge river that fills the entire room. \n" +
                "Now how are we going to get across this to the next room you can see across the river?.");
            Setup.Quit();

            do
            {
                Console.WriteLine("You looked around and see:\n\t 1.) A board \n\t2.) A stick \n\t3.) A switch on the wall.\n" +
              "Which bad choice will you make this time?");
                Setup.ColorChange(10, response = Console.ReadLine().ToUpper().Trim());
                switch (response)
                {
                    case "1":
                        {
                            Console.WriteLine("You attempted to paddle across the river. However, the board was too small \n" +
                                "and you underestimated your own weight. You drowned. You have died.");
                            Environment.Exit(0);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("You died because you picked the wrong option. Game over!");
                            Environment.Exit(0);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("With the way your day is going, who knows what will\nhappen when you throw the switch. Have to try ..... RIGHT?\n" +
                                "You throw the switch and cold air goes through the room, freezing the river. Allowing you to walk with ease.");
                            exit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not an option. Please select a valid option.");
                            exit = false;
                            break;
                        }
                }
            }
            while (exit == false);

            exit = false;
            //Floor 3
            Console.WriteLine("You come across a room littered with treasures and gold. It is sparkling so bright, you could actually be blinded.\n" +
                "You also noticed a door.");
            Setup.Quit();

            do
            {
                Console.WriteLine("What would you like to do?\n\t1.)Stashed the treasures\n\t2.) Ignore and go to door");
                Setup.ColorChange(10, response = Console.ReadLine().ToUpper().Trim());
                switch (response)
                {
                    case "1":
                        {
                            Console.WriteLine("Ignoring your experience thus far, You have been blinded by greed. Everything was an illusion.\n" +
                                "You feel into a deathtrap by a nightmare. You have died");
                            Environment.Exit(0);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Recollecting your experience thus far. You know there is never such a thing as\n" +
                                "a free meal. You ignored all the riched and have escaped to the next room.");
                            exit = true;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Not an option. Please select a valid option.");
                            exit = false;
                            break;
                        }
                }
            }
            while (exit == false);

            exit = false;

            //Floor 4/ Last one to completion
            Console.WriteLine("Good job on making it here this far!. You're the very first surviver.\n");
            Console.WriteLine("Now the room you are at is rumbling, the grotto is collapsing.");
            Setup.Quit();
            Console.WriteLine("You must solve the solve the enchantment " +
                "on the secret door to teleport to the exit.");
            //will set up randoms later but for now ....
            int answer = 8 * 12;
            do
            {
                Console.WriteLine("What is 8 x 12?\n\t1.) {0}\n\t2.) 100 \n\t3.) 88", answer);
                Setup.ColorChange(10, response = Console.ReadLine().ToUpper().Trim());
                switch (response)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("You have escaped. You finished the adventure and came out intact. Bravo.\n" +
                                "As a reward for your surely tasking efforts, youve been registered as the first informed of the next\n" +
                                "Mystical Grotto.");
                            Environment.Exit(0);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("You died because you did not answer correctly. Game over!");
                            Environment.Exit(0);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("You died because you did not answer correctly. Game over!");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not an option. Please select a valid option.");
                            exit = false;
                            break;
                        }
                }
                //want to add boss stage
                //add music stage that deals dmg
                //add room that adds hunger level decreasing health unless food is eaten.
            }
            while (exit == false);
        }
    }
}
