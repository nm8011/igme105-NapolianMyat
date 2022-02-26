using System;
using System.Collections.Generic;
/// <summary>
/// Napolian Myat
/// Project: Homework2
/// Date: 01/31/2022
/// Modified: 02/21/2022
/// Purpose: Extension of hw1
/// For this homework, we will begin creating our Text Adventure using:
///•	Random class
///•	string and math class methods
///•	If Statements and Relational\ Boolean Operators
///•	Nested If Statements
///•	Switch Statements
///•	Loops
/// </summary>
namespace MyatN_HW1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variables
            string name;    //save user name
            //Create a constant value for the number of steps required to get from the driveway to the house.
            //(You can select your own positive integer value as the total number of steps as long as it is less than 100).
            const int numOfSteps = 50;
            //Random
            int diceRoll;
            int deathDoor = 1; //made it 1 so debugging is not so annoying, suppose to be 4

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Basic Info - HW1
            Welcome(); //Welcome the user

            name = GetName(); //Ask for user name

            Rules(); //Explain the rules

            PlayGame(); //Ask whether to play the game or not

            GetToDoor(numOfSteps); //const num of steps to door

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Arrive at door - HW2
            //	Incorporate the player name in the door note.  
            Note(name);

            //o	Create code to simulate dice rolls.  
            //roll 2 dice
            diceRoll = RollDice(1, 7); //to get 2 dice roll of 1-6 added together
            //check diceRoll
            //  *x>4, door opens
            //  *x<=4 player dies
            //if door opens, can proceed, otherwise die
            DeathDoor(name, diceRoll, deathDoor);

            //Ask if player wants to continue or quit
            Quit();

            UpperFloor();

            DungeonFloors();

            





            // What is the flow?
            // path to front door
            // challenge to get in front door
            // what do you see when get in the door?
            // User finds the dungeon door and escapes with the Hershey Candy Golden Globes

        }

        /// <summary>
        /// Introduce the game
        /// </summary>
        public static void Welcome()
        {
            //leave it black
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome to Mystical Grotto");
            Console.WriteLine("__________________________________________\n");
        }
        /// <summary>
        /// Tell player how to play the game
        /// </summary>
        public static void Rules()
        {
            // Section to setup initial storyline
            //•	Provide instructions for how to play the game
            Console.WriteLine("\tMystical Grotto is an interactive text based game.\nDuring the game you will" +
                " be asked for decisions and to enter input.\nYou will be provided with all that you need to know as you play " +
                "the game\nand will only require a keyboard to play. Enjoy the adventure!\n");
            Console.ForegroundColor = ConsoleColor.White;//change color back

        }
        /// <summary>
        /// Prompt user name
        /// </summary>
        /// <returns></returns>
        public static string GetName()
        {
            //Variables
            string name;
            bool valid = false;
            // User starts here – ask for basic information such as user name.
            //•	Ask the user for their name, read it in and save it (It is used multiple times throughout the game)
            Console.Write("Please enter your character name: ");
            name = Console.ReadLine().Trim();
            do
            {
                //user press 'enter'
                if (string.IsNullOrEmpty(name))
                {
                    //will loop again and ask for valid name
                    valid = false;
                    Console.WriteLine("Sorry, you have not inputted a name. Please input a valid name!");
                    name = Console.ReadLine().Trim();
                }
                else
                {
                    //exits loop
                    valid = true;
                }
            }
            while (valid == false);
            //Greetings
            //•	Provide the initial narration, using the name provided by the user.
            //change font color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Nice to meet you, {0} I hope you are prepared to perish in a dark damp lair!\n", name);
            return name;
        }
        /// <summary>
        /// Get 'Y'es or 'N'o to play the game or not 
        /// </summary>
        /// <returns></returns>
        public static void PlayGame()
        {
            //Variables
            string playGame;
            //•	Add a section inquiring if the user wants to start playing the game and asking for a Y/ N response.
            Console.WriteLine("Are you ready to play (Y/N)?");
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.White;
            playGame = Console.ReadLine().Trim().ToUpper(); //trim/toupper senitize userinput

            //In case player enters yes or no instead of y or n
            if (playGame == "YES" || playGame == "NO")
            {
                if (playGame == "NO")
                {
                    Console.Clear();
                    Console.WriteLine("\n*sigh*.... we asked for a 'Y' or an 'N'");
                    Console.WriteLine("Anywhoo, You have decided you are not ready to play the game.\nCome again when you are ready. :)");
                    Environment.Exit(0); //exits program
                }
                playGame = playGame.Substring(0, 1);

            }
            //test
            //Console.WriteLine(playGame);
            if (playGame != "Y")
            {
                Console.Clear();
                Console.WriteLine("You did not enter 'Y'es. You have decided you are not ready to play the game.\nCome again when you are ready. :)");
                Environment.Exit(0);
                //They gave us anything BUT Y
            }
            else
            {
                //nth code continues
            }
        }

        /// <summary>
        /// User arrive to door of house
        /// </summary>
        /// <param name="numOfSteps"></param>
        public static void GetToDoor(int numOfSteps)
        {
            //Ask the user for how many steps to move.
            Console.WriteLine("\nHow many steps are you going to move?");
            //Read the user step input in and convert it to an integer
            int userNumOfSteps = 0;
            bool valid = false; //reset to false
            string response = Console.ReadLine().Trim();
            do
            {
                valid = int.TryParse(response, out int result);//takes response and try to parse to int

                if (valid == false)//if cannot, ask again
                {
                    Console.WriteLine("You have not inputted a valid number of steps, please try again.");
                    response = Console.ReadLine().Trim();
                }
                else// if can, take the value
                {
                    userNumOfSteps = int.Parse(response);
                    valid = true;
                    //nth
                }
            }
            while (valid == false);

            //Calculations for over and under the number of required steps created and used in output. 
            int calcNum = Math.Abs(numOfSteps - userNumOfSteps);

            //user input is greater
            if (userNumOfSteps > numOfSteps)
            {
                Console.WriteLine("You would have walked past the door by {0} steps. You have stopped at the door.", calcNum);
            }
            //user input less than
            else if (userNumOfSteps < numOfSteps)
            {
                Console.WriteLine("You are short of {0} steps. I have increased your steps. Now you are at the door.", calcNum);
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
        public static void Note(string name)
        {
            Console.WriteLine("Hello, {0}. The door is currently locked and can only be opened with a key.", name);
        }
        /// <summary>
        /// Create code to simulate dice rolls.You will need 2 random numbers
        /// and then add the 2 numbers together for the total.  
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int RollDice(int min, int max)
        {

            Random myrand = new Random();
            int rand1 = myrand.Next(min, max);
            int rand2 = myrand.Next(min, max);
            return rand1 + rand2;
        }
        /// <summary>
        /// 	If exiting the game, you must allow the game player to see all the messages on the screen that they lost before the window closes.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diceRoll"></param>
        public static void DeathDoor(string name, int diceRoll, int deathDoor)
        {
            if (diceRoll > deathDoor)
            {
                Console.WriteLine("{0} rolled a {1}. Lady Luck shines upon you, the door somehow magically opened for you.", name, diceRoll);
                //continues
            }
            else
            {
                Console.Clear();
                Console.WriteLine("{0} rolled a {1}. After numerous attempts to picklock the door.\n" +
                    "Sensing your vain stubborn efforts, as if to mock you the mysterious entity behind the door exploded the doors\n" +
                    "blasting you to oblivion. You have died. Game over!", name, diceRoll);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Prompt whether player wants to quit the game or continue
        /// 	If exiting the game, you must allow the game player to see all the messages on the screen that they lost before the window closes
        /// </summary>
        public static void Quit()
        {
            string response;
            Console.WriteLine("You are faced with a difficult decision.");
            Console.WriteLine("Do you wish to quit or continue? Enter 'Q' to quit or anything else to continue");
            response = Console.ReadLine().Trim().Substring(0).ToUpper(); //substring 0 allows for null
            if (string.IsNullOrEmpty(response)) //if user input is null meaning they press "Enter"
            {
                Console.WriteLine("You've decided to continue. Good Luck Adventurer!");

            }
            else
            {
                response = response.Substring(0, 1).ToUpper().Trim();//user senitize
                if (response != "Q")
                {
                    //code continues
                    Console.WriteLine("You've decided to continue. Good Luck Adventurer!");
                }
                else
                {
                    Console.WriteLine("Your persistence is pathetic. You have decided to quit adventuring.");
                    Environment.Exit(0);
                }
            }
           
            

        }

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
        
            string stringColor = StrClass(3); //find 3rd word
            Console.WriteLine("You entered through the door. You are at the corridor glowing a bright {0} color.", stringColor);
            do
            {
                Console.WriteLine("\nYou see 5 rooms within your vicinity. You should probably check each of them out\nThey are:\n\t1 The Kitchen\n\t" +
                    "2 The BedRoom\n\t3 The LivingRoom\n\t4 The Library\n\t5 The GuestRoom.\nWhich one do you wish to visit?");
                choice = Console.ReadLine().Trim();
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
                            //choice = Console.ReadLine().Trim();
                            exit = false;
                            break;
                        }
                }
            }
            while (exit == false);

        }
        /// <summary>
        /// Having an authors block so story is not original yet. Will use this until I figure something more unique and interesting
        /// </summary>
        public static void DungeonFloors()
        {
            string response;
            bool exit = false;
            Console.WriteLine("As you enter the dungeon, you pushed the spider webs out of your way.\n" +
                "You look down and see that you are walking on marshlands-like environemnt. You see a \n" +
                "door across the way. but your feet has sunken into the marsh and you are immobilize.");
          
            Quit(); //ask if to quit before presenting what to do.
            Console.WriteLine("You have chosen not to quit. You begin to access the situation.");


            do
            {
                Console.WriteLine("\nYou look around and found the following in the room. \n\t1.) A rope is hanging from the ceiling.\n" +
                  "\t2.) A blow torch is sitting next to you. \n\t3.) A herb is right next to you\nWhat would you like to do?");
                response = Console.ReadLine().ToUpper().Trim();
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

            Console.WriteLine("Wonderful, you made it off the marshmallows, just to find yourself staring at a chocolate fudge river that fills the entire room. \n" +
                "Now how are we going to get across this to the next room you can see across the river?.");
            Quit();
          
            do
            {
                Console.WriteLine("You looked around and see:\n\t 1.) A board \n\t2.) A stick \n\t3.) A switch on the wall.\n" +
              "Which bad choice will you make this time?");
                response = Console.ReadLine().ToUpper().Trim();
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

                Console.WriteLine("You come across a room littered with treasures and gold. It is sparkling so bright, you could actually be blinded.\n" +
                    "You also noticed a door.");
                Quit();
        
            do
            {
                Console.WriteLine("What would you like to do?\n\t1.)Stashed the treasures\n\t2.) Ignore and go to door");
                response = Console.ReadLine().ToUpper().Trim();
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


            Console.WriteLine("Good job on making it here this far!. You're the very first surviver.\n");
            Console.WriteLine("Now the room you are at is rumbling, the grotto is collapsing.");
            Quit();
            Console.WriteLine("You must solve the solve the enchantment " +
                "on the secret door to teleport to the exit.");
            //will set up randoms but for now ....
            int answer = 8 * 12;
            do
            {
                Console.WriteLine("What is 8 x 12?\n\t1.) {0}\n\t2.) 100 \n\t3.) 88", answer);
                response = Console.ReadLine().ToUpper().Trim();
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
            }
            while (exit == false);
        }
        //Hopefully works
        //NO CODE OUTSIDE HERE
    }
}



