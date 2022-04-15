using System;
using System.IO;
namespace NM_PE18
{   /// <summary>
    /// Napolian Myat
    /// 04/14/2022
    /// Professor. Warren
    /// Project: PE18
    /// Purpose:
    /// For this exercise, you’ll create a text file that contains information about playing pieces for a 
    /// game and then you’ll read that file back in and print the information out on the console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Create a file (using code!) that contains all of the fighter data, separated by commas.
            string fileName = "FighterDatas";
            try
            {
                //a.	Create the necessary object to open the file for writing. 
                StreamWriter output = new StreamWriter(fileName, true);

                //b.	“Hard code” the data in your program. (In other words, do not
                //require user input.) Make sure you write out all four lines of data
                //to the file. A sample file line: “Fokker DR 1,Germany,D,A,13”
                output.WriteLine("Fokker DR1,Germany,D,A,13");
                output.WriteLine("Spad XIII   ,France  ,A,A,16"); //add space for format issues
                output.WriteLine("Sopwith Camel,England,C,A,15");
                output.WriteLine("Albatros D,Germany,B,A,15");
                output.Close(); //closing the file
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine(error.StackTrace);
            }

            try
            {
                //a.	Create the necessary object to open the file for reading.
                StreamReader input = new StreamReader(fileName, true);

                string line = "";
                //b.Read in each line of the file using a loop. (Note: you cannot always know how many
                //lines are in a file, so choose a loop that does not require that information.)
                //c.After you read in a line, display it as described in requirement 3 below.
                while ((line = input.ReadLine()) != null)
                {
                    //•	Delimit your data so you can tell where one field ends and the next one starts.
                    //You’ll need to use the Split( ) method of strings to parse the data.
                    string[] data = line.Split(',');
                    for (int i = 0; i < data.Length; i++)
                    {
                        //•	Format the output by labeling each piece of data for a fighter.
                        //For example, your output should look like this:
                        //Name: Fokker DR 1  Country: Germany  Turn Mode: D Attack Mode: A  Max Damage:: 13
                        switch (i)
                        {
                            case 0:

                                {
                                    Console.Write("\tName: " + data[i]);
                                    break;
                                }
                            case 1:

                                {
                                    Console.Write("\tCountry: " + data[i]);
                                    break;
                                }
                            case 2:

                                {
                                    Console.Write("\tTurn Mode: " + data[i]);
                                    break;
                                }
                            case 3:

                                {
                                    Console.Write("\tAttack Mode: " + data[i]);
                                    break;
                                }
                            case 4:

                                {
                                    Console.Write("\tMax Damage: " + data[i]);
                                    break;
                                }
                            default:
                                { break; }
                        }
                        //Console.WriteLine("\tName: ");
                        //Console.Write("\t" + data[i]);
                    }
                    Console.WriteLine();
                    //while (line != data[data.Length - 1])
                    //{
                    //    Console.WriteLine("\t" + data[]);
                    //}
                }
                //d.	Close the file when you are done.
                input.Close();

            }
            catch (Exception error)
            {
                Console.WriteLine("Reading: " + error.Message);
                Console.WriteLine(error.StackTrace);
            }

            File.Delete(fileName); //delete file so that no redundant information is kept and added on debugging

            /*
             * Name,Country,Turn Mode,Attack Mode,Max Damage
                Fokker DR1,Germany,D,A,13
                Spad XIII,France,A,A,16
                Sopwith Camel,England,C,A,15
                Albatros D,B,A,15
             */
        }
    }
}
