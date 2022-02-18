using System;

namespace GuessTheNumber
{
    /*
     * Guess the number - Design/Logic Problem #2
     */
    class GuesstheNumber
    {
        /// <summary>
        /// Rules: 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Variables
            //playerName
            string playerName;
            //random
            //select random number for number beign guessed
            Random rng = new Random();
            int actualNum = rng.Next(1, 51); //1-50
            //user guess var
            int guess;
           
            //limitGuess
            const int LIMIT_GUESS = 10;
            //quit
            bool quit = false;

            //Method
            //Welcome
            Welcome();
            //Rules
            Rules();
            //Prompt user name
            playerName = GetPlayerName();
            //UserGuess
            //ask user for their guess
            //look at guess - check if guess == random number
            //if not - display wrong guess(maybe too high or too low)
            //check if guess exceeds guessLimit
            //if so end game announce lost
            //if not prompt guess again or to quit
            //if so - yay! winner end game
            //display stats(how many guess, what the number is)

        }
        public static void Welcome()
        {
            Console.WriteLine("Hello, welcome to the game of \"Guess That Number!\"");
        }
        public static void Rules()
        {
            Console.WriteLine("The rules of the game is simple enough. You will have a set number of attempts to guess the number." +
                "\nIf you exceed the guess limit, you lose. If you guess correctly, you win. You can choose to quit in " +
                "\nbetween, but that will result in an automatic lost.\n");
        }
        public static string GetPlayerName()
        {
            string name;
            Console.Write("To get started, what is yours name?: ");
            name = UserInputColor(Console.ReadLine());
            name = Console.ReadLine().Trim();
            Console.WriteLine("Pleasure to meet you {0}!", name);

            return name;
            
        }
        public static string UserInputColor(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string info = "";
            Console.ForegroundColor = ConsoleColor.White;
            return info;
        }

    }
}
