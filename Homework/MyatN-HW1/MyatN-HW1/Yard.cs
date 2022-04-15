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
    class Yard
    {
        //VARIABLES
        private const int NUM_OF_STEPS = 50;
        private const int DEATH_DOOR = 1; //made it 1 so debugging is not so annoying, suppose to be 4
        //access setup.name variable
        private static string name = Setup.Name;
        //•	Create a dictionary to hold our animals/creatures
        //I did creature, string b/c I want to find creatures type and name
        private static Dictionary<Creature, string> creatureDictionary = new Dictionary<Creature, string>();

        private static Creature dragon = new Creature();
        private static Creature sphinx = new Creature();

        private static bool dead = Setup.Dead;
        //PROPERTIES
        public static Dictionary<Creature, string> CreatureDictionary
        {
            get 
            {
                if (!creatureDictionary.ContainsKey(dragon))
                {
                    creatureDictionary.Add(dragon, dragon.Name);
                }
                if(!creatureDictionary.ContainsKey(sphinx))
                {
                                    creatureDictionary.Add(sphinx, sphinx.Name);

                }
                return creatureDictionary; 
            }
            set
            {
                creatureDictionary = value;
            }

        }


        /// <summary>
        /// User arrive to door of house
        /// </summary>
        /// <param name="numOfSteps"></param>
        public static void GetToDoor()
        {

            //Ask the user for how many steps to move.
            Setup.RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                             "~                     Yard                  ~\n" +
                             "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Setup.ColorChange(3, "\tYou have long since heard rumors of the mysterious Mystical Grotto where no man has returned from. \n" +
                    "One day, you have decided to explore the outskirts of the Mansion in which the Mystical Grotto appeared in. \n" +
                    "You have reached the gates of the Mansion. Looking from outside, you see a lush garden. Despite the Mansion\n" +
                    "being abandoned for an indeterminate amount of time, it is surprisely kept. You feel a compelling force to\n" +
                    "enter.");
            string text = ("\n\nTo proceed, you must absolve yourself and move your legs. How many steps are you going to move?");
            //Read the user step input in and convert it to an integer
            int userNumOfSteps;

            userNumOfSteps = Setup.IntValidation(text);

            //Calculations for over and under the number of required steps created and used in output. 
            int steps = userNumOfSteps;
            int remainingSteps = Math.Abs(NUM_OF_STEPS - steps);


            //user input is greater
            if (steps > NUM_OF_STEPS)
            {
                Console.WriteLine("You would have walked past the door by {0} steps if you had kept going. \n" +
                    "You have stopped at the door.", remainingSteps);
            }
            //user input less than
            else if (steps < NUM_OF_STEPS)
            {
                while (steps < NUM_OF_STEPS)
                {
                    text = ("You are short of steps. You have not reached the Mansion yet. No rush. You are enjoying the \n" +
                        "environment around the Mansion which is pristine and serene.\n" +
                    "How many more steps will you take?");
                    userNumOfSteps = Setup.IntValidation(text);
                    steps = steps + userNumOfSteps;
                    remainingSteps = Math.Abs(NUM_OF_STEPS - steps);
                }
                if (steps == NUM_OF_STEPS)
                {
                    Console.WriteLine("You have arrived at the door!");
                }
                else
                {
                    Console.WriteLine("You would have walked past the door by {0} steps if you had kept going. \n" +
                        "You have stopped at the door.", remainingSteps);
                }
            }
            //userinput == const
            else
            {
                Console.WriteLine("You are right on the mark! You have arrived at the door.");
            }
           
        }
        /// <summary>
        /// o	Add a note to the front door that it is locked and needs a key.
        /// 	Incorporate the player name in the door note.  
        /// </summary>
        /// <param name="name"></param>
        public static void Note()
        {
            Console.WriteLine("\nGreetings, {0}. The door is currently locked and can only be opened with a key.\n" +
                              "For some reason there is also a slot machine near the entryway. You also noticed " +
                              "\nthere is a note at the door. You read it, it says: "
                , name);

            Setup.ColorChange(3,"\t _____________________________________________________________________\n" +
                                "\t|\t                                                              |\n" +
                                "\t|\tWelcome, adventurer. As you have probably noticed,            |\n" +
                                "\t|\tthe door is currently lock. Fortune favours the bold.         |\n" +
                                "\t|\tThe only known method of unlocking the door is rolling        |\n" +
                                "\t|\tthe slot machine locating next to the door. If you            |\n" +
                                "\t|\troll unluckily, you will perish. If you roll luckily,         |\n" +
                                "\t|\tthe key will pop out. You will be leaving your fate...        |\n" +
                                "\t|\tup to fate.                                                   |\n" +
                                "\t|\t                                                              |\n" +
                                "\t|_____________________________________________________________________|\n\n");
            Setup.PressToClear(false);
        }

        /// <summary>
        /// If exiting the game, you must allow the game player to see all the messages on the screen that they lost before the window closes.
        /// check diceRoll
        ///  *x > 4, door opens
        ///  *x <= 4 player dies
        ///if door opens, can proceed, otherwise die
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diceRoll"></param>
        public static bool FrontDoor()
        {
            string text;
            bool success;
            int diceRoll;
            //o	Create code to simulate dice rolls.  
            //roll 2 dice
            diceRoll = Setup.RollDice(1, 7); //to get 2 dice roll of 1-6 added together
            if (diceRoll >= DEATH_DOOR)
            {
                success = true;
                
                text = string.Format("\n{0} rolled a {1}. The bare minimum roll is {2}. Lady Luck shines upon you, \n" +
                                  "the slot machine delivers the key in a pod to you.\n"
                                  , name, diceRoll, DEATH_DOOR);
                Setup.ColorChange(4, text);
            }
            else
            {
                success = false;
                text = string.Format("\n{0} rolled a {1}. The bare minimum roll is {2}. You failed to roll the bare minimum, you did not" +
                                  "\nget the key. You then resorted to picklocking. After numerous attempts to picklock the door." +
                                  "\nSensing your vain stubborn efforts, as if to mock you the mysterious entity behind the Grotto " +
                                  "\nexploded the doors blasting you to oblivion.\n"
                                  , name, diceRoll, DEATH_DOOR);
                Setup.ColorChange(6, text);
            }
            //check diceRoll
            //  *x > 4, door opens
            //  *x <= 4 player dies
            //if door opens, can proceed, otherwise die
            if (success == true)
            {
                Yard.FrontDoorChallenge();
                Setup.GameEnd("Q", null);
                Setup.PressToClear(true);
            }
            else
            {
                Setup.GameEnd("D", null);

            }
            return dead;
        } 

        /// <summary>
        /// 
        /// </summary>
        public static bool FrontDoorChallenge()
        {
            string choice;
            bool success = false;
            Yard.CreatureNameCheck();
            string text = string.Format("\nBefore you could open the door, {0} fabled creatures appeared before you from\n" +
                "seemingly nowhere. ", Yard.CreatureDictionary.Count);
            Setup.ColorChange(3, text);

            if (Setup.DifficultyLevelChosen >= 1)
            {
                text = string.Format("There is a {0} Dragon with {1} sharp horns and {3} legs. It is \n" +
                    "exhaling violent grunts and snorts at times. It goes by the name \"{2}\". \n",
                    dragon.CreatureColor, dragon.Feature, dragon.Name, dragon.NumOfLegs);
                Setup.ColorChange(3, text);
            }

            if (Setup.DifficultyLevelChosen >= 2)
            {
                text = string.Format("There is a {0} Sphinx with {1} ferocious claws and {3} legs. It looking at you with gazes  \n" +
                    "that is akin to one would look at tender juicy meat. It goes by the name \"{2}\".\n"
                    , sphinx.CreatureColor, sphinx.Feature, sphinx.Name, sphinx.NumOfLegs);
                Setup.ColorChange(3, text);
            }
            if (Setup.DifficultyLevelChosen == 1)
            {
                dead = Creature.DragonWish();
            }


            
            if (Setup.DifficultyLevelChosen == 2)
            {
                Console.WriteLine("They prompt you to choose one of them to access the door.\n" +
                    "Did you think it was going to be that easy?\n");
                do
                {
                    Console.Write("\nWhich will you choose? " +
                    "\n\tA.) The Sphinx" +
                    "\n\tB.) The Dragon\n>");
                    choice = Setup.UserInput().ToUpper();
                    switch (choice)
                    {
                        case "A":
                            {
                                dead = Creature.SphinxRiddle();
                                success = true;
                                break;
                            }
                        case "B":
                            {
                                dead = Creature.DragonWish();
                                success = true;
                                break;
                            }
                        default:
                            {
                                Setup.ColorChange(6, "That is not an option\n");
                                success = false;
                                break;
                            }
                    }
                }
                while (success != true);
            }
            return dead;
        }
        /// <summary>
        /// Change sphinx name if it is same as dragon
        /// </summary>
        public static void CreatureNameCheck()
        {
            if(dragon.Name == sphinx.Name)
            {
                do
                {
                    int num = Setup.randGen(0, sphinx.NameArr.Length);
                    sphinx.Name = sphinx.NameArr[num];
                } while (dragon.Name != sphinx.Name);
                
            }
        }

    }
}
