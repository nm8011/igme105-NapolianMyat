using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// Project: Homework5
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
///•	Abstraction
///•	Inheritance
///•	Polymorphism
///•	Interfaces
/// </summary>
namespace MyatN_HW1
{
    class Grotto
    {
        //VARIABLE
        private static bool dead = Setup.Dead;

        /// <summary>
        /// DungeonFloors
        /// </summary>
        public static bool DungeonFloors()
        {
            //Grotto
            Setup.RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                            "~                The Grotto                 ~\n" +
                            "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            //Ask to continue
            Steps();
            Console.Clear();
            //Floor1: Marshland
            Setup.RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                            "~          The Grotto: Marshland            ~\n" +
                            "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Marshland();
            Console.Clear();

            //Floor2: River
            Setup.RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                            "~             The Grotto: River             ~\n" +
                            "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            River();
            Console.Clear();

            //Floor3: TreasureRoom
            Setup.RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                            "~          The Grotto: TreasureRoom         ~\n" +
                            "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            TreasureRoom();
            Console.Clear();

            //Floor4/ Last one til completion
            Setup.RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                            "~         The Grotto: EnchantedDoor         ~\n" +
                            "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            EnchantedDoor();
            Console.Clear();
            return dead;

        }
        public static void Steps()
        {
            Setup.ColorChange(3, "As you enter the secret room, you noticed spider cobwebs blocking your way.\n" +
                           "You come to a realization that no one has been here in quite a while. You\n" +
                           "look down and could make out some stepstones and underneath it, pure darkness.");
            Console.Write("\nDo you want to take those steps down?");
            Setup.GameEnd("Q", "");
        }
        /// <summary>
        /// Floor1 - Marshland
        /// Use logic
        /// </summary>
        public static void Marshland()
        {
            int response;
            bool exit = false;
            string text = string.Format("You took that step down and stumbled. You fell to the ground. \n" +
                "You look down and see that you are in a marshlands-like environment. \n" +
                "You see a door across the way. but your feet has sunken into the marsh\n" +
                "and you are immobilize, slowly sinking in deeper.\n");

            Setup.ColorChange(3, text);

            //ik we suppose to prompt for quitting for every userentry but that doesnt appear to be asthetic to me so
            //im doing it where I want it to be an option
            Console.WriteLine("You begin to access the situation");


            do
            {
                response = Setup.IntValidation("\nYou look around and found the following in the marsh. \n\t1.) A rope with a hook is lying around\n" +
                  "\t2.) A stick is protruding from the ground. \n\t3.) A mushroom is right next to you\nWhat would you like to do?");
                switch (response)
                {
                    case 1:
                        {
                            Setup.ColorChange(4, "You used the rope to hook onto a nearby tree and pull yourself across\n" +
                                "You made it across the place with relative ease and came out unharmed!");
                            exit = true;
                            break;
                        }
                    case 2:
                        {
                            Setup.GameEnd("D", "You used the stick to maneauver around. However, the stick broke before you\n" +
                                "reach the exit, you begin to sink faster due to your eratic movement.\n" +
                                "You begin to suffocate slowly but surely.");
                            break;
                        }
                    case 3:
                        {
                            Setup.GameEnd("D", "who do you think you are? Mario? Did you think you would get\n" +
                                "a power up or something? You have eaten a schroom and then you\n" +
                                "began to hallucinate that your surroundings are a big fluff of\n" +
                                "pillows. You are smothered by the softness. Slowly sinking to\n" +
                                "your doom. You're gonna sleep alright. An eternal one.");
                            break;
                        }
                    default:
                        {
                            Setup.ColorChange(6, "That is not an available option");
                            exit = false;
                            break;
                        }
                }
            }
            while (exit == false);
            Setup.GameEnd("Q", null);
        }
        /// <summary>
        /// Floor2: River
        /// Outsmart the system
        /// </summary>
        public static void River()
        {
            int response;
            bool exit = false;
            Setup.ColorChange(3, "\nWonderful, you made it off the submerging marshlands, now you are at a surging river blasting\n" +
                "fragments of woodpieces from who knows where. You looked to where the water leads to\n" +
                "You could make out a wall with underneath a deep dark chasm, however its a bit dark to\n" +
                "see. Now how are you going to get across this river to the next area you can see across\n" +
                "the wide river?. You looked around and see:");

            do
            {
                response = Setup.IntValidation("\n\t1.) A driftboard \n\t2.) A stick \n\t3.) A flashlight.\n" +
              "Which item will you use this time?");

                switch (response)
                {
                    case 1:
                        {
                            Setup.GameEnd("D", "\nYou attempted to paddle across the river. However, the board was too small \n" +
                                "and you underestimated your own weight. You drowned.\n");
                            break;
                        }
                    case 2:
                        {
                            Setup.GameEnd("D", "");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("You used your flashlight to observed the wall with more scrutiny. You could\n" +
                                "see a tiny passage, small, but enough for you to grasp a foothold and make it across\n" +
                                "You safely made your way across leaning on the way.");
                            exit = true;
                            break;
                        }
                    default:
                        {
                            exit = false;
                            break;
                        }
                }
            }
            while (exit == false);
            Setup.GameEnd("Q", null);

        }
        /// <summary>
        /// Floor3: TreasureRoom
        /// Resist Temptation for treasures
        /// </summary>
        public static void TreasureRoom()
        {
            int response;
            bool exit = false;
            Console.WriteLine("\nYou come across a room littered with treasures and gold. It is sparkling so bright, you could actually be blinded.\n" +
                "You also noticed a exit doorway.");
            Setup.GameEnd("Q", null);

            do
            {
                response = Setup.IntValidation("\nWhat would you like to do?\n\t1.)Stashed the treasures\n\t2.) Ignore and go to the exit door");
                switch (response)
                {
                    case 1:
                        {
                            Setup.GameEnd("D", "Ignoring your experience thus far, You have been blinded by greed. Everything was an illusion.\n" +
                                "You feel into a deathtrap by a nightmare. You have died");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Recollecting your experience thus far. You know there is never such a thing as\n" +
                                "a free meal. You ignored all the riched and have escaped to the next room.");
                            exit = true;
                            break;
                        }

                    default:
                        {
                            exit = false;
                            break;
                        }
                }
            }
            while (exit == false);
            Setup.GameEnd("Q", null);

        }
        /// <summary>
        /// Floor4: EnchantedDoor
        /// Solve mathematical equation
        /// </summary>
        public static void EnchantedDoor()
        {
            int response;
            bool exit = false;
            Console.WriteLine("Congratulations on making it here this far!. You're the very first surviver.\n");
            Console.WriteLine("Now the room you are at is rumbling, the grotto is collapsing.");
            Console.WriteLine("You must solve the solve the enchantment on the secret door \n" +
                "to teleport to the final exit. Otherwise, you will perish.");

            //will set up randoms later but for now ....
            int answer = 8 * 12;

            do
            {
                string text = string.Format("What is 8 x 12?\n\t1.) {0}\n\t2.) 20 \n\t3.) 88", answer);
                response = Setup.IntValidation(text);
                switch (response)
                {
                    case 1:
                        {
                            Setup.GameEnd("W", "You have escaped. You finished the adventure and came out intact. Bravo.\n" +
                                "As a reward for your surely tasking efforts, youve been registered as the first informed of the next\n" +
                                "Mystical Grotto.");
                            break;
                        }
                    case 2:
                        {
                            text = string.Format("Wrong answers.The correct answer is { 0 }", answer);
                            Setup.GameEnd("D", text);
                            break;
                        }
                    case 3:
                        {
                            text = string.Format("Wrong answers.The correct answer is { 0 }", answer);
                            Setup.GameEnd("D", text);
                            break;
                        }
                    default:
                        {
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
        //NO METHOD OUTSIDE HERE
    }
}
