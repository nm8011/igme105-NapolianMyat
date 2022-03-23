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
            bool exit;
            string text;
            string stringColor = StrClass(3); //find 3rd word


            Setup.RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                            "~                  Mansion                  ~\n" +
                            "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            text = string.Format("You opened the door with a loud resounding screech. You entered through the door.\n" +
                                 "There is a blinding light stunning you for a brief moment. You soon opened your eyes and \n" +
                                 "looked inside. You are now at the vast corridor glowing a bright {0} color. \n" +
                                 "As you scanned the Mansion with your eyes in discretion, you made a keen observation."
                                 , stringColor.ToLower());

            Setup.ColorChange(3, text);

            //for room entering
            //cannot enter more than once for 1st, 2nd, 3rd, 5th room
            //room 4 (The library) is an exception as it leads to dungeon floors
            int i = 0; //first room
            int j = 0; //second room
            int k = 0; //third room
            int l = 0; //fourth room
            int m = 0; //fifth room
            do
            {
                Console.Write("\nYou see 5 rooms labeled within your vicinity. You should probably check each of them out\nThey are:\n\t1 The Kitchen\n\t" +
                    "2 The BedRoom\n\t3 The LivingRoom\n\t4 The Library\n\t5 The GuestRoom.\nWhich one do you wish to visit?\n>");
                choice = Setup.UserInput();
                switch (choice)
                {
                    case "1":
                        {
                            if(i == 0)
                            {
                                Setup.ColorChange(3, "\nYou notice in the kitchen some items that could be essential to your adventure. " +
                                "\nThe kitchen is very bright and lively with a fridge mounted right in the middle. \nYou looked inside the fridge and found" +
                                "an abundant of food and water. \nYou also located a cutting board nearby"); //get shield & food, water
                                i++;
                            }
                            else
                            {
                                Setup.ColorChange(6, "You have already visited this room. Choose another.");
                            }
                            exit = false;
                            break;
                        }
                    case "2":
                        {
                            if (j == 0)
                            {
                                Setup.ColorChange(3, "\nYou entered the Bed Room. The living room has a TV that is playing some channels\n" +
                                    "you are not familiar with, as well as jazz music playing in the background. There is a set of \n" +
                                    "headphones connected to a disc player."); //will need maybe to block noise(dmg from sound), less dmg over time so without, the player
                                                                               //will lose a certain amount of hp each round or step or whatev(not decided)
                                j++;
                            }
                            else
                            {
                                Setup.ColorChange(6, "You have already visited this room. Choose another.");
                            }
                            exit = false;

                            break;
                        }
                    case "3":
                        {
                            if (k == 0)
                            {
                                Setup.ColorChange(3, "\nThe Living room is neatly organized, there is a sweet scent in the air. Hey theres some \nmarshmellows attach to a fire poker" +
                                    "As you tried to pick the marshmellows, you got a cut. Luckily you \ndid not lose any health points. You observed that the " +
                                    "fire poker is oddly sharp. \nThat might prove handy. "); //weapon, fight against minions and boss later, otherwise fistfights dmg will be halved.
                                k++;
                            }
                            else
                            {
                                Setup.ColorChange(6, "You have already visited this room. Choose another.");
                            }
                            exit = false;
                            break;
                        }
                    case "4": //library
                        {
                            if (l == 0)
                            {
                                Setup.ColorChange(3, "\nThe Library has a ladder leading up to the top of the shelves. As you checked out \nthe area, you notice a bunch of potions. " +
                                    "Theres a note nearby. You read it, it says:" +
                                    "\n\t ______________________________________________________________" +
                                    "\n\t|                                                              |" +
                                    "\n\t|      To whomever it concerns,                                |" +
                                    "\n\t|  Take great discretion towards what I am about to tell you.  |" +
                                    "\n\t|  If you choose to explore the grotto, you will face a great  |" +
                                    "\n\t|  amount of danger. I have prepared you some potions for      |" +
                                    "\n\t|  your adventure. However PLEASE PICK ONLY ONE potions for    |" +
                                    "\n\t|  consumption. Anymore will kill an ordinary man.             |" +
                                    "\n\t|______________________________________________________________|\n\n");
                                //potions will be, 2x dmg increased, health over time/rounds, TBD later

                                Console.WriteLine("You got down and noticed a sculpture nearby a pillar. Based on your recollection\n" +
                                    "of how most hidden rooms are, it probably hides a secret passage. You yanked the \n" +
                                    "sculpture. Mechanism start to spin. The room rumbles and revealed a hidden door. \n" +
                                    "Its the door to the basement.");
                                exit = GoDungeon();
                                l++;
                            }
                            else //player enter library once before and opened secret passage but chosen to adventure other rooms
                            {
                                exit = GoDungeon();
                            }
                            break;

                        }
                    case "5":
                        {
                            if (m == 0)
                            {
                                Setup.ColorChange(3, "\nThe Guest Room has an allocated bed. You search all over the room for items that will \nassist your journey. You checked under the bed " +
                                    "and found a secret suitcase. You need a key to open it. Good thing \na key is right besides the nightstand. You used it to open the case. \nPerfect match! " +
                                    "You checked the contents. There is a sturdy but surprisely nimble cloth\ninside. Hey! That might make you more resiliant.");//armour, maybe add some options to choose from
                                                                                                                                                                 //can halves dmg taken?
                                m++;
                            }
                            else
                            {
                                Setup.ColorChange(6, "You have already visited this room. Choose another.");

                            }

                            exit = false;

                            break;
                        }
                    default://if not valid input prompt again
                        {
                            Setup.ColorChange(6,"\nOops! You have not picked an available option. Please pick again.");
                            exit = false;
                            break;
                        }
                }
            }
            while (exit != true);
            Setup.PressToClear(true);


        }
        public static bool GoDungeon()
        {
            bool valid = false; //check for valid response
            string response;
            bool exit; //
            do
            {
                Console.WriteLine("\nThe door to the basement is open.");
                response = Setup.StringValidation("\nDo you wish to enter? (Y/N)").ToUpper();
                if (response == "N")
                {
                    Console.WriteLine("You have choosen to explore other rooms first.");
                    valid = true;
                    exit = false;
                }
                else if (response == "Y")
                {
                        Console.WriteLine("\nThe basement is emmitting a murderous hue. You entered and the door behind you is " +
                            "\nshut tight with a loud slam. You tried to backout but no amount of hammering will open this door.\n" +
                            "\nYou must persist forward."); //introduce basement dungeon floors);
                        valid = true;
                    exit = true;
                }
                else
                {
                    Setup.ColorChange(6, "We asked for 'Y' or 'N'!");
                    valid = false;
                    exit = false;
                }
            }
            while (valid != true);
            return exit;
        }
    }
}
