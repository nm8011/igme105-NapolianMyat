using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace NM_PE19
{
    class Plane

    {
        //VARIABLE
        private string fileName;
        private string planeName;
        private string country;
        private char turnMode;
        private char attackMode;
        private double cost;
        private int maxDamage;

        public Plane(string fileName, string planeName, string country, 
            char turnMode, char attackMode, double cost, int maxDamage)
        {
            this.fileName = fileName;
            this.planeName = planeName;
            this.country = country;
            this.turnMode = turnMode;
            this.attackMode = attackMode;
            this.cost = cost;
            this.maxDamage = maxDamage;
        }

        /// <summary>
        /// 	One should take all of the data for a single plane as parameters,
        /// as well as a file name, and write it to that file.
        /// </summary>
        public void WriteBinary()
        {
            try
            {
                //Create stream and binarywriter
                Stream plane = File.OpenWrite(fileName);
                BinaryWriter output = new BinaryWriter(plane);

                //Hardcode data
                output.Write(planeName);
                output.Write(country);
                output.Write(turnMode);
                output.Write(attackMode);
                output.Write(cost);
                output.Write(maxDamage);

                output.Close();//closing file
            }
            catch (IOException x)
            {
                Console.WriteLine("Error creating {0}: ", fileName + x.Message);
            }
        }
        /// <summary>
        /// 	The other should take a file name, read the file and print the data out.
        /// </summary>
        public void ReadBinary()
        {
            try
            {
                //Create binaryreader
                BinaryReader input = new BinaryReader(File.OpenRead(fileName));

                ///•	Select appropriate data types for the data being represented.
                ///The idea is to take up as little space as possible.  If you store 
                ///all the data as Strings, you will NOT get any credit.
                string strData = input.ReadString();
                Console.WriteLine("Name: " +strData);

                strData = input.ReadString();
                Console.WriteLine("Country: " +strData);

                char charData = input.ReadChar();
                Console.WriteLine("Turn Mode: " + charData);

                charData = input.ReadChar();
                Console.WriteLine("Attack Mode: " + charData);

                double dblData = input.ReadDouble();
                Console.WriteLine("Cost: "+dblData);

                int intData = input.ReadInt32();
                Console.WriteLine("Max Damage: "+intData);

                //close file
                input.Close();
            }
            catch(IOException x)
            {
                Console.WriteLine("Error reading {0}: ", fileName + x.Message);
            }

        }
    }
}
