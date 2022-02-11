using System;

namespace TestReviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            const int MAX_POWER = 100;
            string device;
            int healthLevel = 100;
            int brightness = 88;
            int temperature = 10;
            int upgrade = 0;
            bool answer = false;
            //Random
            Random rng = new Random();
            int choice = rng.Next(0, 3);


            //prompt for type of device
            Console.Write("What device do you want? (ie. (C)omputer, (I)Phone, (M)ac)\n>");
            Console.ForegroundColor = ConsoleColor.Cyan;
            device = Console.ReadLine().ToUpper().Trim().Substring(0,1); //(0,1) NOT (0) - you keep forgetting
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine(device);//test
            do
            {
                switch (device)
                {
                    case "I":
                        {
                            Console.WriteLine("You have chosen an \"Iphone\"!");
                            answer = true;
                            break;
                        }
                    case "C":
                        {
                            Console.WriteLine("You have chosen a \"Computer\"!");
                            answer = true;
                            break;
                        }
                    case "M":
                        {
                            Console.WriteLine("You have chosen a \"Mac\"!");
                            answer = true;
                            break;
                        }
                        //if user doesnt provide valid response, prompt again
                    default:
                        {
                            Console.Write("Oopsie! You have not selected a valid device type. \nPlease input one of the provided device type that you would like.\n>");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            device = Console.ReadLine().ToUpper().Trim().Substring(0, 1); //(0,1) NOT (0) - you keep forgetting
                            Console.ForegroundColor = ConsoleColor.White;
                            answer = false; //just in case
                            break;
                        }
                }
            }
            while (answer == false);

        }
    }
}
