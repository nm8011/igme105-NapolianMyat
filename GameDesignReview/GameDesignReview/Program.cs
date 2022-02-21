using System;

namespace GameDesignReview
{
    class PassageGame
    {
        /// <summary>
        /// Instruction
        /// To Set up the game each player rolls a die. The highest scoring roll will be the player who begins the game.
        /// The player who rolled the lowest
        /// If he rolls the point number, he gets one point. If he rolls doubles of the point number he gets two points.
        /// Each player gets only one roll per turn.
        /// The first player to get 11 points wins.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //Variables
            Random rng = new Random();
            //need 2 dice(6 sided)
            int Die1;
            int Die2;
            //# of players
            const int MAX_PLAYERS = 2;

            //Player score - max 11
            int Player1Score = 0;
            int Player2Score = 0;

            //Player Names
            string PlayerName1;
            string PlayerName2;
            //GamePoint #
            int GamePoint = 0;
            //WhoseTurn
            int PlayerTurn = 0;

            //methods
            //Game Name/Welcome
            Welcome();

            //Get PlayerNames
            PlayerName1 = GetPlayerNames("1");
            PlayerName2 = GetPlayerNames("2");

            //Rules
            //Display
            //Start of game turns - lowest number rolls for game point
            Console.WriteLine("Lets begin!");
            Console.WriteLine(PlayerName1 + " rolls their die.");
                //Player 1 roll die
            Die1 = RollDie(rng, 1, 7);
            Console.WriteLine("They rolles a:" + Die1);
                //Player 2 roll die
            Console.WriteLine(PlayerName1 + " rolls their die.");

            Die2 = RollDie(rng, 1, 7);
                //Look at die for highest and lowest... highest goes 1st, 2nd player rolls again for game point
                //check if die 1 is higher than die 2
            if (Die1> Die2)
            {
                Console.WriteLine("Player1 has the higher die they will go first. ");
                PlayerTurn = 1;
            }
            else if(Die2 > Die1)
            {
                Console.WriteLine("Player2 has the higher die they will go first. ");
                PlayerTurn = 2;
            }
            else
            {
                Console.WriteLine("It was a tie, we'll roll for who goes first!");
                PlayerTurn = RollDie(rng, 1, 3);
                Console.WriteLine("We have a winner for going first, it is player:" + PlayerTurn);
            }
            //lower player rolls again for game point
          
            switch(PlayerTurn)
            {
                case 1:
                {
                Console.WriteLine("Player" + PlayerTurn + " will now roll for the game point");
                        GamePoint = RollDie(rng, 1, 7);
                break;
                }
                case 2:
                {
                Console.WriteLine("Player" + PlayerTurn + " will now roll for the game point");
                GamePoint = RollDie(rng, 1, 7);
                break;
                }
                default:
                {
                Console.WriteLine("Oops!");
                break;
                }
            }

            //Turns
                //Roll the dice
                //Look at die #'s and check EACH one to point number
                    //Math Point # get 1 point, mathc BOTH die get 2 points
                    //Add points to score
                    //Display after turn
                    //Check if won - if didnt switch turn, else WINNER
        }
        public static int RollDie(Random rng, int min, int max)
            //for 6 sided die, send 1,7 to get between 1 and 6 for player
        {
            int diceroll = rng.Next(min, max);
            return diceroll;
        }
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Passage");
        }
        public static string GetPlayerNames(string PlayerNumber)
        {
            Console.WriteLine("Please enter the name for Player" + PlayerNumber + ":");
            string name = Console.ReadLine().Trim();
            return name;
            //ERROR CODE HERE////
        }
        public static void Rules()
        {
            Console.WriteLine("To set up the game each player rolls a die. The highest scoring roll will be the player who begins the game. The player who" +
                "\nrolled the lowest number will now roll a second time and the number on the die becomes\nthe point. Starting with the first " +
                "\nplayer, players take tursn rolling two dice. If he rolls the point number, he gets one point.\nIf he rolls doubles of the " +
                "\npoint number he gets two points. Each player gets only one. The first player to get 11points win.");
        }
    }
}
