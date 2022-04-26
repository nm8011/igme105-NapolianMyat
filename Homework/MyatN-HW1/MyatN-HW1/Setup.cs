using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
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
    //READ IN FILE - OPEN FILE
    //SAVE FILE - OPEN FILE, WRITE IN FILE
    
    static class Setup
    {
        //VARIABLES
        //null so when i debug, i can run part codes without error
        //Create a constant value for the number of steps required to get from the driveway to the house.
        //(You can select your own positive integer value as the total number of steps as long as it is less than 100).
        private static string name = null;
        private static bool dead;
        private static int[] userInformationArr = new int[NUM_OF_USER_INFO];
        private const int NUM_OF_USER_INFO = 10;
        public static List<string> foodList;
        public static int difficultyLevelChosen;
        public static string fileName = "SaveFile.txt";
        //PROPERTIES
        public static string Name { get { return name; } }       
        public static string FileName { get { return fileName; } }
        public static bool Dead
        {
            get { return dead; }
            set 
            { dead = value;
                if (dead == true)
                {
                    Environment.Exit(0);
                }
            }
        }
        public static int DifficultyLevelChosen 
        { 
            get { return difficultyLevelChosen; }
            set { difficultyLevelChosen = value; }
        }

        public static int[] UserInformationArr
        {
            get { return userInformationArr; }
        }
        public static List<string>FoodList
        {
            get { return foodList; }
            set { foodList = value; }
        }
        //METHODS
        public static bool doesFileExist()
        {
            if(File.Exists(fileName))
            {
                return true;
            }
            else { return false; }
        }
        public static void askToSave(string saveLine)
        {
            bool save = Setup.YesNoQuestions("Do you wish to save?", "You saved your progress.", "You did not save.");
            if (save == true)
            {
                Setup.WriteStream(saveLine);
            }
            else
            {
                Console.WriteLine("If you die or quit, you will start from the beginning.");
            }
        }
        public static void WriteStream(string saveLine)
        {
            try
            {
                Stream saveFile = File.OpenWrite(fileName);
                StreamWriter sw = new StreamWriter(saveFile);
                //If they select save, prompt them that any previous save points of theirs will be overwritten.
                Console.WriteLine("Selecting save will overwrite all previous save points.");
                bool answer = Setup.YesNoQuestions("Do you wish to continue?", "You have selected to save.", "You denied.");
                if (answer == true)
                {
                    File.Delete(fileName);
                    saveFile = File.OpenWrite(fileName);
                    sw = new StreamWriter(saveFile);
                    sw.WriteLine(saveLine);
                    sw.Close();
                }
                else
                {
                    Console.WriteLine("You did not save your progress. This means you will start from the beginning" +
                        "\nif you wish to play again.");
                }

            }
            catch (IOException x)
            {
                Console.WriteLine("Error creating file: " + x.Message);
                Environment.Exit(0);
            }
        }
        public static string ReadStream()
        {
            string line = null;
            try
            {
                StreamReader sr = new StreamReader(fileName);
                line = sr.ReadLine();
            }
            catch (IOException x)
            {
                Console.WriteLine("Error reading file: " + x.Message);
                Environment.Exit(0);
            }
            return line;

        }
        /// <summary>
        /// Introduce the game name
        /// </summary>
        public static void Welcome()
        {
            //leave it black
            Console.BackgroundColor = ConsoleColor.Black;

            RandColor("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                           "~        Welcome to Mystical Grotton        ~ " +
                         "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

            
            //Console.WriteLine("\n__________________________________________\n");
        }
        /// <summary>
        /// Tell player how to play the game
        /// </summary>
        public static void Rules()
        {
            // Section to setup initial storyline
            //change font color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //•	Provide instructions for how to play the game
            Console.WriteLine("\tMystical Grotto is an interactive text based game. During\n" +
                               "the game you will be asked for decisions and to enter input. You\n" +
                               "will be provided with all that you need to know as you play the\n" +
                               "game and will only require a keyboard to play. Enjoy the adventure!\n");
            Console.ForegroundColor = ConsoleColor.White;//change color back

        }
        /// <summary>
        /// Prompt user name
        /// </summary>
        /// <returns></returns>
        public static string GetName()
        {
            // User starts here – ask for basic information such as user name.
            //•	Ask the user for their name, read it in and save it (It is used multiple times throughout the game)
            name = Setup.StringValidation("Please enter your character name: ");

            //Cap first letter, lowercase rest
            name = (name.Substring(0,1).ToUpper()) + name.Substring(1, name.Length-1).ToLower();
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
            bool valid = false;

            //Greetings
            //•	Provide the initial narration, using the name provided by the user.
            Console.WriteLine("Nice to meet you {0}. I hope you are prepared to perish in a dark damp lair!\n", name);
            //•	Add a section inquiring if the user wants to start playing the game and asking for a Y/ N response.
            //In case player enters yes or no instead of y or n
            do
            {
                playGame = StringValidation("Are you ready to play (Y/N)?").ToUpper(); //trim/toupper senitize userinput
                if (playGame == "YES" || playGame == "NO")
                {
                    if (playGame == "NO")
                    {
                        Console.WriteLine("\n*sigh*.... we asked for a 'Y' or an 'N'");
                        GameEnd("", "\nAnywhoo, You have decided you are not ready to play the game.\nCome again when you are ready. :)\n");
                    }
                    else
                    {
                        Console.WriteLine("\n*sigh*.... we asked for a 'Y' or an 'N'");
                        valid = true;
                    }
                    playGame = playGame.Substring(0, 1);
                }
                else
                {
                    valid = true;
                }
            }
            while (valid == false);

            //test
            //Console.WriteLine(playGame);
            if (playGame != "Y")
            {
                playGame = playGame.Substring(0, 1).ToUpper();
                if (playGame == "Y")
                {
                    Console.WriteLine("You did not enter 'Y'es. However, we detected a 'Y' in your input and will take it as a 'Y'es");
                }
                else
                {
                    GameEnd("", "\nYou did not enter 'Y'es. You have decided you are not ready to play the game.\nCome again when you are ready. :)\n");
                    //They gave us anything BUT Y
                }
            }
            else
            {
                Console.WriteLine("Regardless, you braved yourself forward and decided to commence your adventure.");
                //nth code continues
            }

            playGame = playGame.Substring(0, 1);

            PressToClear(true);
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
            int rand1 = randGen(min, max);
            int rand2 = DiceRoll(1,7, 2);
            return rand1 + rand2;
        }
        public static int DiceRoll(int min, int max, int numOfDice)
        {

            Random myrand = new Random();
            int rand1 = myrand.Next(min, max);
            int rand2 = myrand.Next(min, max);
            return (rand1 + rand2)*numOfDice/numOfDice;
        }
        public static int randGen(int min, int max)
        {

            Random myrand = new Random();
            int rand = myrand.Next(min, max);
            return rand;
        }

        /// <summary>
        /// EndGame(Option Q||D + message)
        /// Q: Prompt whether player wants to quit the game or continue, 
        /// D: EndGame cuz player dies
        /// </summary>
        public static void GameEnd(string option, string message)
        {
            switch (option)
            {
                case "Q":
                    {
                        string response;
                        Console.WriteLine("\nYou are faced with a difficult decision.");
                        Console.WriteLine("Do you wish to quit or continue? Enter 'Q' to quit or anything else to continue" + message);
                        response = Setup.UserInput().Substring(0).ToUpper(); //substring 0 allows for null
                        if (string.IsNullOrEmpty(response)) //if user input is null meaning they press "Enter"
                        {
                            ColorChange(4,"You've decided to continue. Good Luck Adventurer!");
                            Setup.Dead = false;
                        }
                        else
                        {
                            response = response.Substring(0, 1).ToUpper().Trim();//user senitize
                            if (response != "Q")
                            {
                                //code continues
                                ColorChange(4,"You've decided to continue. Good Luck Adventurer!");
                                Setup.Dead = false;
                            }
                            else
                            {
                                ColorChange(6, "\nYour persistence is pathetic. You have decided to quit adventuring. Goodbye.");
                                Setup.Dead = true;
                            }
                        }
                        break;
                    }
                case "D":
                    {
                       
                        ColorChange(6, message);
                        ColorChange(6, "\nYou have died. The last adventure you'll be getting is the one to hell!\n" +
                            "   ^  ^    \n" +
                            "  (o｀~｀)o=E  \n");
                        Setup.Dead = true;
                        break;
                    }
                case "W":
                    {

                        ColorChange(4, message);
                        Setup.Dead = true;
                        break;
                    }
                default:
                    {
                        ColorChange(6, message);
                        Setup.Dead = true;
                        break;
                    }
            }
        }

        /// <summary>
        /// Change color
        /// 1.) Blue
        /// 2.) Red
        /// 3.) DarkYellow
        /// 4.) Green
        /// 5.) Magenta
        /// 6.) DarkRed
        /// 7.) DarkGreen
        /// 8.) Yellow
        /// 9.) White
        /// 10.) Cyan
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static void ColorChange(int color, string message)
        {
            //variable
            switch (color)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 6:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 7:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 8:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case 9:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(message);
                        break;
                    }
                case 10:
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(message);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                default:
                    {
                        Console.Write("oops");
                        break;
                    }
            }
        }

        /// <summary>
        /// Rainbow Color print
        /// </summary>
        /// <param name="message"></param>
        public static void RandColor(string message)
        {
            int randColor;

            int i = 0;
            while (i < message.Length)
            {
                randColor = Setup.randGen(1, 9);
                ColorChange(randColor, message.Substring(i, 1));
                i++;
            }
        }

        /// <summary>
        /// Clear input for asthetic purposes
        /// true to clear
        /// false just to print readkey
        /// </summary>
        public static void PressToClear(bool wantToClear)
        {
            bool clear = wantToClear;
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();

            //lazy so if I want to use readkey but not clear add bool != true
            if (clear == true)
            {
                Console.Clear();
            }
        }

        /// <summary>
        /// UserInput = cyan
        /// Trim() included
        /// </summary>
        /// <returns></returns>
        public static string UserInput()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine().Trim();
            Console.ForegroundColor = ConsoleColor.White;
            return input;
        }

        /// <summary>
        /// Takes response and tryparse it until valid
        /// </summary>
        /// <param name="wrong"></param>
        /// <returns></returns>
        public static int IntValidation(string message)
        {
            bool valid;
            string response;
            do
            {
                Console.Write(message + "\n>");
                response = UserInput();
                valid = int.TryParse(response, out int result);//takes response and try to parse to int
                if (valid == false)//if cannot, ask again
                {
                    ColorChange(6, "You have not enter a valid int.");
                    valid = false;

                }
                else// if can, take the value
                {
                    valid = true;
                    //nth
                }
            }
            while (valid != true);
            return int.Parse(response);
        }
        /// <summary>
        /// Takes response and check for empty spaces and enter
        /// Accept error message and print it and reprompt until correct
        /// </summary>
        /// <param name="response"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string StringValidation(string message)
        {
            bool valid;
            string response;
            do
            {
                Console.Write(message + "\n>");
                response = UserInput(); //change user input to cyan for differentiation
                if (string.IsNullOrEmpty(response))//if cannot, ask again
                {
                    Setup.ColorChange(6, "\nYou have not enter a valid answer. Please try again.\n");
                    valid = false;

                }
                else// if can, take the value
                {
                    valid = true;
                    //nth
                }
            }
            while (valid != true);
            return response;
        }
        /// <summary>
        /// Create a new method in your setup class to gather information from our user
        /// </summary>
        public static void GettingInformation(int minValueOFInput, int maxValueOfInput)
        {
            //Variable
            bool valid = false;
            string text = string.Format("Please enter a number between {0}-{1}!", minValueOFInput, maxValueOfInput);

            //•	 Explain that we are getting information to personalize the game to them.
            //a.	Prompts the user for 10 integer numbers 
            Console.WriteLine("Before we begin, we would like to ask you for some information\n" +
                "to personalize the game for you. First we will ask you for {0} numbers between {1} and {2}"
                ,NUM_OF_USER_INFO, minValueOFInput, maxValueOfInput);

            ////////////////////////////////////////////////////////////
            /////////////   Loop Until condition fulfilled  ////////////
            ////////////////////////////////////////////////////////////
            ///for validation of user input is within range of required
            for (int i = 0; i < NUM_OF_USER_INFO; i++) //e.Your loop may NOT set the limit as a hard - coded number of 10
            {
                do
                {
                    ////d.	Store user values in the array
                    userInformationArr[i] = IntValidation("\nEnter number: "); //b.	Verify all user entry is an integer value
                    if (userInformationArr[i] >= minValueOFInput && userInformationArr[i] <= maxValueOfInput) //if userInput is within range
                    {
                        Console.WriteLine("You've entered {0} number(s) out of {1}", i + 1, NUM_OF_USER_INFO);
                        valid = true;
                    }
                    else //else reprompt
                    {
                        ColorChange(6, text); //(re-prompting if necessary
                        valid = false;
                    }
                } while (valid != true);
            }

            ///////////////////////////////////////////////////////////////
            /////////   Print out info   //////////////////////////////////
            ///////////////////////////////////////////////////////////////
            Console.WriteLine("Thank you for inputting your {0} favorite numbers!\n You gave the following values:\n", NUM_OF_USER_INFO);
            foreach (var num in userInformationArr)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("We'll use these later in the game.");
        }
        /// <summary>
        /// •	Create UserFoodList method.
        /// </summary>
        /// <param name="userFoodList"></param>
        public static List<string> UserFoodList(List<string> userFoodList, int minNumOfFood)
        {
            string response;
            bool done = false;
            //•	Create user description for the information we are asking for and ask user for input
            Console.WriteLine("To customize your gaming experience a little more. \n" +
                "We need you to enter 3 of your favorite food. \n" +
                "You may enter as more if you wish. (1 per prompt).");
            for (int i = 0; i < minNumOfFood; i++)
            {
                response = Setup.StringValidation("Please enter a food: ");
                userFoodList.Add(response);
            }
            do
            {
                done = YesNoQuestions("Would you like to add another food? (Y/N)", null, "You decided not to enter anymore food");
                if(done != true)
                {
                    response = Setup.StringValidation("\nPlease enter a food: ");//•Check that user entered string data and re-prompt if string is empty.
                    userFoodList.Add(response);
                }
                
                //•	Verify user input for both Y/N (done entering, or continue) – re-prompting if invalid
            } while (done != true);
            //Display the list of food entered by the user when they have said they are done 
            Console.WriteLine("\nThanks for the list of food! You have entered:");
            foreach (var food in userFoodList)
            {
                Console.WriteLine(food);
            }
            FoodList = userFoodList;
            PressToClear(true);
            return userFoodList;
        }
        /// <summary>
        /// Prompt until user input Y/N
        /// returns bool Y=false, N=true
        /// </summary>
        /// <param name="text"></param>
        /// <param name="yesStatement"></param>
        /// <param name="noStatment"></param>
        /// <returns></returns>
        public static bool YesNoQuestions(string text, string yesStatement, string noStatment)
        {
            string response;
            bool success = false;
            bool decision = false;
            do
            {
                response = StringValidation("\n" +text).ToUpper().Substring(0,1);
                if(response == "Y")
                {
                    ColorChange(4, "\n" +yesStatement);
                    decision = false;
                    success = true;
                }
                else if(response == "N")
                {
                    ColorChange(6, "\n"+noStatment);
                    decision = true;
                    success = true;
                }
                else
                {
                    ColorChange(6, "\nYou did not input Y/N.");
                    success = false;
                }

            } while (success != true);
            return decision;
        }
        public static int DifficultyLevel()
        {
            int response;
            bool success = false;
           
            do
            {
                Console.WriteLine("What difficulty level would you like to select for this game? (1-{0})", Yard.CreatureDictionary.Count);
                response = Setup.IntValidation(null);
                switch (response)
                {
                    case 1:
                        {
                            Console.WriteLine("You've selected Level {0} difficulty mode", response);
                            success = true;

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("You've selected Level {0} difficulty mode", response);
                            success = true;
                            break;
                        }
                    default:
                        {
                            success = false;
                            Console.WriteLine("Sorry that difficulty level is not available.");
                            break;
                        }
                }
            } while (success != true);
            DifficultyLevelChosen = response;
            return response;
        }
        //No methods beyond here
    }
}
