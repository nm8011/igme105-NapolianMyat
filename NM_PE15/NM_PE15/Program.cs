using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Napolian Myat
/// PE15 - Inheritance
/// Professor. Warren
/// 04/04/2022
/// </summary>
namespace NM_PE15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class> myClass = new List<Class>();
            //a.	Creates one of each character type.
            Warrior myWarrior = new Warrior(200, 50, 10, "Brax", 10);
            Wizard myWizard = new Wizard(75, 100, 125, "Max", 5);
            Thief myThief = new Thief(125, 75, 20, "Rax", 25);
            string text;

            myClass.Add(myWarrior);
            myClass.Add(myWizard);
            myClass.Add(myThief);

            //b.	Lists the character data for each one using toString
            text = myWarrior.Tostring("Warrior");
            Console.WriteLine(text);
            text = myThief.Tostring("Thief");
            Console.WriteLine(text);
            text = myWizard.Tostring("Wizard");
            Console.WriteLine(text);

            //c.	Changes the intelligence in some way for each character.
            myWarrior.changeIntelligenceValue(5);
            myWizard.changeIntelligenceValue(20);
            myThief.changeIntelligenceValue(2);
            Console.WriteLine("\nNew Stats:");

            //NEw Stats
            //d.Lists the character data again using toString.
            text = myWarrior.Tostring("Warrior");
            Console.WriteLine(text);
            text = myThief.Tostring("Thief");
            Console.WriteLine(text);
            text = myWizard.Tostring("Wizard");
            Console.WriteLine(text);







        }
    }
}
