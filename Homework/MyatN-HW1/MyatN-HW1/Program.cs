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

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Basic Info - HW1
            Welcome(); //Welcome the user

            name = GetName(); //Ask for user name

            Rules(); //Explain the rules

            PlayGame(); //Ask whether to play the game or not

            GetToDoor(numOfSteps); //const num of steps to door

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Arrive at door - HW2
            //	Incorporate the player name in the door note.  
            Note(name);

            //o	Create code to simulate dice rolls.  
            //roll 2 dice
            diceRoll = RollDice(1, 7); //to get 2 dice roll of 1-6 added together
            //check diceRoll
            //  *x>4, door opens
            //  *x<=4 player dies
            //if door opens, can proceed, otherwise die
            CheckDiceRoll(name, diceRoll);

            //Ask if player wants to continue or quit
            Quit();




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
            Console.WriteLine("\tMystical Grooto is an interactive text based game.\nDuring the game you will" +
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
            Console.WriteLine("Nice to meet you, {0} I hope you are prepared to die in a sugar coma!\n", name);
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
        /// 	Incorporate the player name in the door note.  
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
        /// 	If exiting the game, you must allow the game player to see all the messages on the screen that they lost before the window closes.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diceRoll"></param>
        public static void CheckDiceRoll(string name, int diceRoll)
        {
            if (diceRoll > 4)
            {
                Console.WriteLine("{0} rolled a {1}. Lady Luck shines upon you, the door somehow magically opened for you.",name, diceRoll);
                //continues
            }
            else
            {
                Console.Clear();
                Console.WriteLine("{0} rolled a {1}. After numerous attempts to picklock the door.\n" +
                    "Sensing your vain stubborn efforts, as if to mock you the mysterious entity behind the door exploded the doors\n" +
                    "blasting you to oblivion. You have died. Game over!",name, diceRoll);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Prompt whether player wants to quit the game or continue
        /// 	If exiting the game, you must allow the game player to see all the messages on the screen that they lost before the window closes
        /// </summary>
        public static void Quit()
        {
            bool quit = false;
            string response;
           
            Console.WriteLine("Do you wish to quit or continue? Enter 'Q' to quit or anything else to continue");
            response = Console.ReadLine().Trim().Substring(0, 1).ToUpper();
            if (response != "Q")
            {
                //code continues
                Console.WriteLine("You've decided to continue. Good Luck Adventurer!");
                quit = false;
            }
            //doesnt work?
            //else if (string.IsNullOrEmpty(response))
            //{
            //    quit = false;
            //    Console.WriteLine("You've decided to continue. Good Luck Adventurer!");
            //}
            else
            {
                quit = true;
                Console.WriteLine("Your persistence is pathetic. You have decided to quit adventuring.");
                Environment.Exit(0);
            }
         
        }

        /// <summary>
        /// having trouble
        /// </summary>
        /// <param name="num"></param>
        public static string StrClass(int num)
        {
            //	Create a constant string with 8 colors separated by a comma
            const string MY_COLORS = "Blue,Red,Orange,Yellow,Green,Purple,Violet,Brown";
            int find = MY_COLORS.IndexOf(",");
            string tempword = MY_COLORS.Substring(find + 1, MY_COLORS.Length - find - 1);
            Console.WriteLine(tempword);

            int i = 1;
            while (i>=num)
            {
                find = tempword.IndexOf(",");
                tempword = tempword.Substring(find + 1, tempword.Length);
                Console.WriteLine(tempword);

            }
            tempword = tempword.Substring(0, find-1);
            return tempword;
        }
        public static void UpperFloor()
        {
            string choice;
            bool valid = false;
            string stringColor = StrClass(2);
            Console.WriteLine("You entered through the door. You are at the corridor glowing a bright {0} color.", stringColor);
            Console.WriteLine("You see 5 rooms within your vicinity. You should probably check each of them out\nThey are:\n\t1 The Kitchen\n\t" +
                "2 The BedRoom\n\t3 The LivingRoom\n\t4 The Library");
            do
            {
                choice = Console.ReadLine().Trim();
                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("You notice in the kitchen some items that could be essential to your adventure. " +
                                "\nThe kitchen is very bright and lively, but emitting a murderous hue. "); //get weapon
                            valid = true;
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("You entered the Bed Room. The living room has a TV that is playing some channels\n" +
                                "you are not familiar with, as well as jazz music playing in the background. There is a set of \n" +
                                "headphones connected to a disc player."); //will need maybe to block noise
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("The Livingroom is neatly organized, you notice out of the corner of your eye a fire poker.\n" +
                                "That might prove handy. "); //another weapon
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("The Library");
                            break;
                        }
                }
            }
            while (valid == false);
        
        }
        //You opened 
        //okayy


        //NO CODE OUTSIDE HERE
    }
}


