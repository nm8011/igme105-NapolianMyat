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
    static class Mansion
    {
        /// <summary>
        /// having trouble
        /// </summary>
        /// <param name="num"></param>
        public static string StrClass(int num)
        {
            //	Create a constant string with 8 colors separated by a comma
            const string MY_COLORS = "Blue,Red,Orange,Yellow,Green,Purple,Violet,Brown";
            string tempword = MY_COLORS;
            int find = MY_COLORS.IndexOf(",");
            int i = 1;
            while (i < num)
            {
                find = tempword.IndexOf(",");
                tempword = tempword.Substring(find + 1, tempword.Length - find - 1);
                //test
                //Console.WriteLine(tempword);
                i++;
            }
            tempword = tempword.Substring(0, tempword.IndexOf(","));
            //Console.WriteLine(tempword);
            return tempword;
        }
        public static void UpperFloor()
        {
            string choice;
            bool exit = false;
            string text;
            string stringColor = StrClass(3); //find 3rd word


            Setup.RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                            "~                  Mansion                  ~\n" +
                            "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            text = string.Format("You opened the door with a loud resounding screech. You entered through the door.\n " +
                                 "There is a blinding light stunning you for a brief moment. You soon opened your eyes and \n" +
                                 "looked inside. You are now at the vast corridor glowing a bright {0} color."
                                 , stringColor);

            Setup.ColorChange(3, text);
            do
            {
                Console.WriteLine("\nYou see 5 rooms within your vicinity. You should probably check each of them out\nThey are:\n\t1 The Kitchen\n\t" +
                    "2 The BedRoom\n\t3 The LivingRoom\n\t4 The Library\n\t5 The GuestRoom.\nWhich one do you wish to visit?");
                Setup.ColorChange(10, choice = Console.ReadLine().Trim());
                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("\nYou notice in the kitchen some items that could be essential to your adventure. " +
                                "\nThe kitchen is very bright and lively with a fridge mounted right in the middle. \nYou looked inside the fridge and found" +
                                "an abundant of food and water. \nYou also located a cutting board nearby"); //get shield & food, water
                            exit = false;
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("\nYou entered the Bed Room. The living room has a TV that is playing some channels\n" +
                                "you are not familiar with, as well as jazz music playing in the background. There is a set of \n" +
                                "headphones connected to a disc player."); //will need maybe to block noise(dmg from sound), less dmg over time so without, the player
                                                                           //will lose a certain amount of hp each round or step or whatev(not decided)
                            exit = false;

                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\nThe Living room is neatly organized, there is a sweet scent in the air. Hey theres some \nmarshmellows attach to a fire poker" +
                                "As you tried to pick the marshmellows, you got a cut. Luckily you \ndid not lose any health points. You observed that the " +
                                "fire poker is oddly sharp. \nThat might prove handy. "); //weapon, fight against minions and boss later, otherwise fistfights dmg will be halved.
                            exit = false;
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("\nThe Library has a ladder leading up to the top of the shelves. As you checked out \nthe area, you notice a bunch of potions." +
                                "Theres a note nearby. You read it:" +
                                "\n\"To whomever it concerns,\n\t" +
                                "Take great discretion towards what I am about to tell you. The maze you will face will have great amount of danger. I have prepared\n" +
                                "you some potions for your adventure. However PLEASE PICK ONLY ONE potions for consumption. Anymore will kill an ordinary man.\"\n");
                            //potions will be, 2x dmg increased, health over time/rounds, TBD later

                            Console.WriteLine("You got down and noticed a sculpture nearby a pillar. Based on your recollection of how most hidden rooms are, \n" +
                                "it probably hides a secret passage. You yanked the scupture. Mechanism start to spin. The room rumbles and revealed\n" +
                                "a hidden door. Its the door to the basement.");
                            Console.WriteLine("\nThe basement is emmitting a murderous hue. You entered and the door behind you is \nshut tight with a loud slam. You tried to backout but no amount of hammering will open this door.\n" +
                               "\nYou must persist forward."); //introduce basement dungeon floors
                            exit = true;
                            break;

                        }
                    case "5":
                        {
                            Console.WriteLine("\nThe Guest Room has an allocated bed. You search all over the room for items that will \nassist your journey. You checked under the bed " +
                                "and found a secret suitcase. You need a key to open it. Good thing \na key is right besides the nightstand. You used it to open the case. \nPerfect match! " +
                                "You checked the contents. There is a sturdy but surprisely nimble cloth\ninside. Hey! That might make you more resiliant.");//armour, maybe add some options to choose from
                                                                                                                                                             //can halves dmg taken?
                            exit = false;

                            break;
                        }
                    default://if not valid input prompt again
                        {
                            Console.WriteLine("\nOops! You have not picked an available option. Please pick again.");
                            //Console.WriteLine("You see 6 rooms within your vicinity. You should probably check each of them out\nThey are:\n\t1 The Kitchen\n\t" +
                            //        "2 The Bed Room\n\t3 The Living Room\n\t4 The Library\n\t5 The Guest Room\n\t6 The Basement\n\nWhich one do you wish to visit?");
                            //Setup.UserInput(choice = Console.ReadLine().Trim());
                            exit = false;
                            break;
                        }
                }
            }
            while (exit == false);

        }
    }
}
